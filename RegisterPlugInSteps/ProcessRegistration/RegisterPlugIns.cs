using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.Crm.Sdk.Messages;
using System.Xml.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Tooling;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Tooling.Connector;

namespace RegisterPlugInSteps
{    
    public class RegisterPlugIns
    {
        private  IOrganizationService crmService;
        private StringBuilder logMessages = new StringBuilder();
        public RegisterPlugIns(IOrganizationService service)
        {
            crmService = service;
        }
        private enum ComponentType
        {            
            PluginAssemblyComponentID = 91,
            SDKMessageProcessingStepComponentID = 92,
            SDKMessageProcessingStepImageComponentID = 93,
        };

        public StringBuilder AddOrUpdatePluginAssembly(string assemblyLocation)
        {
            var loadedAssembly = Assembly.LoadFile(assemblyLocation);
            string[] attributes = loadedAssembly.GetName().FullName.Split(",=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            if (attributes == null)
            {
                logMessages.Append("Please select valid plugin assembly to update or register !!");
                return logMessages;
            }

            EntityCollection retrievedPluginAssembly = RetrievePluginAssemblyByName(attributes[0]);
            Guid pluginAssemblyId = RegisterPluginAssemblyByName(assemblyLocation, attributes, retrievedPluginAssembly);
            return logMessages;
        }
        public StringBuilder ProcessRegistration(string assemblyFolderLocation, string solutionName, string xmlRegistry)
        {            
            using (XmlReader xmlReader = XmlReader.Create(new StringReader(xmlRegistry)))
            {                                
                Entity solutiontoaddComponents = GetSolution(solutionName);
                string uniqueSolutionName = string.Empty;
                if(solutiontoaddComponents != null)
                {
                    uniqueSolutionName = solutiontoaddComponents.Attributes["uniquename"].ToString();
                }
                Guid pluginTypeId = Guid.Empty;
                Guid pluginAssemblyId = Guid.Empty;
                Guid sdkProcessingStepId = Guid.Empty;                
                Guid StepImageId = Guid.Empty;

                while (xmlReader.Read())
                {
                    // check starting element of the xml
                    if (xmlReader.IsStartElement() && xmlReader.Name == "Solution")
                    {
                        do
                        {
                            #region register plugin assembly and add to solution
                            string assemblyName = xmlReader["Assembly"];
                            var assemblyFullPath = assemblyFolderLocation + "\\" + assemblyName;
                            var loadedAssembly = Assembly.LoadFile(assemblyFullPath);
                            string[] attributes = loadedAssembly.GetName().FullName.Split(",=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                            EntityCollection retrievedPluginAssembly = RetrievePluginAssemblyByName(assemblyName.Substring(0, assemblyName.Length - 4)); // remove .dll text
                            pluginAssemblyId = RegisterPluginAssembly(xmlReader, assemblyFullPath, attributes, retrievedPluginAssembly);
                            // Add plugin to given solution
                            AddComponentToCRMSolution(pluginAssemblyId, Convert.ToInt32(ComponentType.PluginAssemblyComponentID), uniqueSolutionName, crmService);
                            #endregion
                            if (xmlReader.ReadToDescendant("Plugin"))
                            {
                                do
                                {
                                    EntityCollection pluginTypeCollection = RetrievePluginType(xmlReader);
                                    pluginTypeId = RegisterPluginType(pluginAssemblyId, xmlReader, pluginTypeCollection);

                                    #region register plugin steps
                                    if (xmlReader.ReadToDescendant("Step"))
                                    {
                                        do
                                        {
                                            Guid messageId = Guid.Empty;
                                            Guid messageFilterId = Guid.Empty;
                                            messageId = GetMessageId(crmService, xmlReader);
                                            messageFilterId = GetMessageFilterId(crmService, xmlReader, messageId);
                                            int stage = GetStage(xmlReader);
                                            int mode = GetMode(xmlReader);                                            
                                            int supportedDeployment = GetSupportedDeploymentType(xmlReader);
                                            EntityCollection stepCollection = RetrieveStep(xmlReader, messageId, messageFilterId, mode, stage, pluginTypeId);
                                            sdkProcessingStepId = RegisterStep(pluginTypeId, xmlReader, mode, stage, supportedDeployment, messageId, messageFilterId, stepCollection);
                                            AddComponentToCRMSolution(sdkProcessingStepId, Convert.ToInt32(ComponentType.SDKMessageProcessingStepComponentID), uniqueSolutionName, crmService);                                                                                                   //AddComponentToSolution(pluginAssemblyId,)


                                            #region register plugin step images
                                            if (xmlReader.ReadToDescendant("Image"))
                                            {
                                                int imageType = 0;
                                                do
                                                {
                                                    imageType = GetImageType(xmlReader, imageType);
                                                    EntityCollection imageCollection = RetrieveImage(xmlReader, imageType, sdkProcessingStepId);
                                                    var imageToBeUpdated = new Entity("sdkmessageprocessingstepimage");
                                                    StepImageId = RegisterImage(sdkProcessingStepId, xmlReader, imageType, imageCollection, imageToBeUpdated);

                                                } while (xmlReader.ReadToNextSibling("Image"));
                                                xmlReader.ReadToNextSibling("Images");
                                            }
                                            #endregion
                                        } while (xmlReader.ReadToNextSibling("Step"));
                                        xmlReader.ReadToNextSibling("Steps");
                                    }
                                    #endregion
                                } while (xmlReader.ReadToNextSibling("Plugin"));
                                xmlReader.ReadToNextSibling("PluginTypes");

                            }
                        } while (xmlReader.ReadToNextSibling("Solution"));
                    }
                }                
            }

            return logMessages;
        }
        
        private  Entity GetSolution(string solutionName)
        {
            Entity Solution = new Entity("solution");
            var solutions = new QueryExpression("solution");
            solutions.ColumnSet = new ColumnSet(true);
            solutions.Criteria.AddCondition("friendlyname", ConditionOperator.Equal, solutionName);
            var solutionsCollection = crmService.RetrieveMultiple(solutions);
            if (solutionsCollection.Entities.Count > 0)
            {
                return solutionsCollection.Entities[0];                
            }            
            return null;
        }

        private  Guid RegisterImage(Guid sdkProcessingStepId, XmlReader xmlReader, int imageType, EntityCollection imageCollection, Entity pluginSetpImageToBeUpdated)
        {
            Guid PluginStepImageId;
            pluginSetpImageToBeUpdated["attributes"] = xmlReader["Attributes"];
            pluginSetpImageToBeUpdated["entityalias"] = xmlReader["EntityAlias"];
            pluginSetpImageToBeUpdated["messagepropertyname"] = xmlReader["MessagePropertyName"];
            pluginSetpImageToBeUpdated["imagetype"] = new OptionSetValue(imageType);            
            pluginSetpImageToBeUpdated["sdkmessageprocessingstepid"] = new EntityReference("sdkmessageprocessingstep", sdkProcessingStepId);
            if (imageCollection.Entities.Count > 0)
            {
                PluginStepImageId = imageCollection.Entities[0].Id;
                pluginSetpImageToBeUpdated["sdkmessageprocessingstepimageid"] = PluginStepImageId;
                crmService.Update(pluginSetpImageToBeUpdated);
            }
            else
            {
                PluginStepImageId = new Guid(xmlReader["Id"]);
                if (PluginStepImageId == Guid.Empty)
                {
                    Guid id = Guid.NewGuid();
                    PluginStepImageId = id;
                }
                pluginSetpImageToBeUpdated["sdkmessageprocessingstepimageid"] = PluginStepImageId;
                crmService.Create(pluginSetpImageToBeUpdated);
            }
            logMessages.Append(Environment.NewLine);
            logMessages.Append("Image with EntityAlias: " + xmlReader["EntityAlias"] + " Related To StepId " + sdkProcessingStepId + " Registered Successfully");
            return PluginStepImageId;
        }

        private  EntityCollection RetrieveImage(XmlReader xmlReader, int value, Guid stepId)
        {
            QueryExpression querySdkMessageImage = new QueryExpression("sdkmessageprocessingstepimage");
            querySdkMessageImage.ColumnSet = new ColumnSet(true);
            querySdkMessageImage.Criteria.AddCondition("sdkmessageprocessingstepid", ConditionOperator.Equal, stepId);
            querySdkMessageImage.Criteria.AddCondition("entityalias", ConditionOperator.Equal, xmlReader["EntityAlias"]);
            querySdkMessageImage.Criteria.AddCondition("imagetype", ConditionOperator.Equal, value);            
            var imageCollection = crmService.RetrieveMultiple(querySdkMessageImage);
            return imageCollection;
        }

        private  int GetImageType(XmlReader xmlReader, int imageType)
        {
            switch (xmlReader["ImageType"])
            {
                case "PreImage":
                    imageType = 0;
                    break;
                    ;
                case "PostImage":
                    imageType = 1;
                    break;
            }

            return imageType;
        }

        private  Guid RegisterStep(Guid pluginTypeId, XmlReader xmlReader, int mode, int stage, int supportedDeployment, Guid messageId, Guid messageFilterId, EntityCollection stepCollection)
        {            
            var sdkMessageStepToUpdate = new Entity("sdkmessageprocessingstep");
            sdkMessageStepToUpdate["name"] = xmlReader["Name"];
            sdkMessageStepToUpdate["mode"] = new OptionSetValue(mode);
            sdkMessageStepToUpdate["rank"] = Convert.ToInt32(xmlReader["Rank"]);
            sdkMessageStepToUpdate["stage"] = new OptionSetValue(stage);
            sdkMessageStepToUpdate["supporteddeployment"] = new OptionSetValue(supportedDeployment);
            sdkMessageStepToUpdate["eventhandler"] = new EntityReference("plugintype", pluginTypeId);
            sdkMessageStepToUpdate["sdkmessageid"] = new EntityReference("sdkmessage", messageId);
            Guid sdkProcessingStepId;
            bool asyncautodelete = false;
            if (mode == 1 && xmlReader["AsyncAutoDelete"] != null)
            {
                switch (xmlReader["AsyncAutoDelete"])
                {
                    case "true":
                        asyncautodelete = true;
                        break;
                    case "false":
                        asyncautodelete = false;
                        break;
                }
                sdkMessageStepToUpdate["asyncautodelete"] = asyncautodelete;
            }
            if (xmlReader["CustomConfiguration"] != null)
            {
                sdkMessageStepToUpdate["configuration"] = xmlReader["CustomConfiguration"];
            }
            if (messageFilterId != null && messageFilterId != Guid.Empty)
            {
                sdkMessageStepToUpdate["sdkmessagefilterid"] = new EntityReference("sdkmessagefilter", messageFilterId);
            }
            if (xmlReader["FilteringAttributes"] != null)
            {
                sdkMessageStepToUpdate["filteringattributes"] = xmlReader["FilteringAttributes"];
            }
            if (stepCollection.Entities.Count > 0)
            {
                sdkProcessingStepId = stepCollection.Entities[0].Id;
                sdkMessageStepToUpdate["sdkmessageprocessingstepid"] = sdkProcessingStepId;
                crmService.Update(sdkMessageStepToUpdate);
            }
            else
            {
                sdkProcessingStepId = new Guid(xmlReader["Id"]);
                if (sdkProcessingStepId == Guid.Empty)
                {
                    Guid id = Guid.NewGuid();
                    sdkProcessingStepId = id;
                }
                sdkMessageStepToUpdate["sdkmessageprocessingstepid"] = sdkProcessingStepId;
                crmService.Create(sdkMessageStepToUpdate);
            }
            logMessages.Append(Environment.NewLine);
            logMessages.Append("Step " + xmlReader["Name"] + " with " + sdkProcessingStepId + " Registered Successfully");
            return sdkProcessingStepId;
        }

        private  EntityCollection RetrieveStep(XmlReader xmlReader, Guid messageId, Guid messageFilterId, int mode, int stage, Guid pluginTypeId)
        {
            QueryExpression querySdkMessageSteps = new QueryExpression("sdkmessageprocessingstep");
            querySdkMessageSteps.ColumnSet = new ColumnSet(true);
            querySdkMessageSteps.Criteria.AddCondition("eventhandler", ConditionOperator.Equal, pluginTypeId);
            querySdkMessageSteps.Criteria.AddCondition("name", ConditionOperator.Equal, xmlReader["Name"]);
            querySdkMessageSteps.Criteria.AddCondition("sdkmessageid", ConditionOperator.Equal, messageId);
            if (xmlReader["PrimaryEntityName"] != null && xmlReader["PrimaryEntityName"] != "")
            {
                querySdkMessageSteps.Criteria.AddCondition("sdkmessagefilterid", ConditionOperator.Equal, messageFilterId);
            }
            querySdkMessageSteps.Criteria.AddCondition("mode", ConditionOperator.Equal, mode);
            querySdkMessageSteps.Criteria.AddCondition("stage", ConditionOperator.Equal, stage);
            querySdkMessageSteps.Criteria.AddCondition("rank", ConditionOperator.Equal, Convert.ToInt32(xmlReader["Rank"]));
            var stepCollection = crmService.RetrieveMultiple(querySdkMessageSteps);
            return stepCollection;
        }

        private  int GetSupportedDeploymentType(XmlReader xmlReader)
        {
            int supportedDeployment = 0;
            switch (xmlReader["SupportedDeployment"])
            {
                case "ServerOnly":
                    supportedDeployment = 0;
                    break;
                case "OfflineOnly":
                    supportedDeployment = 1;
                    break;
                case "Both":
                    supportedDeployment = 2;
                    break;
            }

            return supportedDeployment;
        }

        private  int GetStage(XmlReader xmlReader)
        {
            int stage = 0;
            switch (xmlReader["Stage"])
            {
                case "PreOutsideTransaction":
                    stage = 10;
                    break;
                case "PreInsideTransaction":
                    stage = 20;
                    break;
                case "PostOutsideTransaction":
                    stage = 40;
                    break;
            }

            return stage;
        }

        private  int GetMode(XmlReader xmlReader)
        {
            int mode = 0;
            switch (xmlReader["Mode"])
            {
                case "Synchronous":
                    mode = 0;
                    break;
                case "Asynchronous":
                    mode = 1;
                    break;
            }

            return mode;
        }
        
        private  Guid RegisterPluginType(Guid pluginAssemblyId, XmlReader xmlReader, EntityCollection pluginTypeCollection)
        {
            Guid pluginTypeId;
            var pluginToBeUpdated = new Entity("plugintype");
            pluginToBeUpdated["pluginassemblyid"] = new EntityReference("pluginassembly", pluginAssemblyId);
            pluginToBeUpdated["typename"] = xmlReader["TypeName"];
            pluginToBeUpdated["name"] = xmlReader["Name"];
            pluginToBeUpdated["friendlyname"] = xmlReader["FriendlyName"];
            pluginToBeUpdated["description"] = xmlReader["Description"];
            if (pluginTypeCollection.Entities.Count > 0)
            {
                pluginTypeId = pluginTypeCollection.Entities[0].Id;
                pluginToBeUpdated["plugintypeid"] = pluginTypeId;
                crmService.Update(pluginToBeUpdated);
            }
            else
            {
                pluginTypeId = new Guid(xmlReader["Id"]);
                pluginToBeUpdated["plugintypeid"] = pluginTypeId;
                crmService.Create(pluginToBeUpdated);
            }
            logMessages.Append(Environment.NewLine);
            logMessages.Append("Plugin " + xmlReader["Name"] + " with " + pluginTypeId + " Registered Successfully " + DateTime.Now.ToString());
            logMessages.Append(Environment.NewLine);
            logMessages.Append("*********************************************************************************************************************************");
            return pluginTypeId;
        }
        
        private  EntityCollection RetrievePluginType(XmlReader xmlReader)
        {
            QueryExpression pluginType = new QueryExpression("plugintype");
            pluginType.ColumnSet = new ColumnSet(true);
            pluginType.Criteria.AddCondition("name", ConditionOperator.Equal, xmlReader["Name"]);
            var pluginTypeCollection = crmService.RetrieveMultiple(pluginType);
            return pluginTypeCollection;
        }
        
        private  Guid RegisterPluginAssembly(XmlReader xmlReader, string assemblyPath, string[] attributes, EntityCollection retrievedPluginAssembly)
        {
            Guid pluginAssemblyId;
            var assemblyToUpdate = new Entity("pluginassembly");
            assemblyToUpdate["name"] = attributes[0];
            assemblyToUpdate["version"] = attributes[2];
            assemblyToUpdate["culture"] = attributes[4];            
            assemblyToUpdate["publickeytoken"] = attributes[6];
            assemblyToUpdate["sourcetype"] = new OptionSetValue(0);
            assemblyToUpdate["isolationmode"] = new OptionSetValue(2);
            assemblyToUpdate["content"] = Convert.ToBase64String(File.ReadAllBytes(assemblyPath));
            string operation = "Registered";
            if (retrievedPluginAssembly.Entities.Count > 0)
            {
                pluginAssemblyId = retrievedPluginAssembly.Entities[0].Id;
                assemblyToUpdate["pluginassemblyid"] = pluginAssemblyId;
                crmService.Update(assemblyToUpdate);
                operation = "Updated";
            }
            else
            {
                pluginAssemblyId = new Guid(xmlReader["Id"]);
                assemblyToUpdate["pluginassemblyid"] = pluginAssemblyId;
                crmService.Create(assemblyToUpdate);
            }
            logMessages.Append(Environment.NewLine);
            logMessages.Append("Plugin Assembly :" + attributes[0] + " with " + pluginAssemblyId + " " + operation + " Registered Successfully " + DateTime.Now.ToString());
            return pluginAssemblyId;
        }

        private Guid RegisterPluginAssemblyByName(string assemblyPath, string[] attributes, EntityCollection retrievedPluginAssembly)
        {
            Guid pluginAssemblyId;
            var assemblyToUpdate = new Entity("pluginassembly");
            assemblyToUpdate["name"] = attributes[0];
            assemblyToUpdate["version"] = attributes[2];
            assemblyToUpdate["culture"] = attributes[4];            
            assemblyToUpdate["publickeytoken"] = attributes[6];
            assemblyToUpdate["sourcetype"] = new OptionSetValue(0);
            assemblyToUpdate["isolationmode"] = new OptionSetValue(2);
            assemblyToUpdate["content"] = Convert.ToBase64String(File.ReadAllBytes(assemblyPath));
            string operation = "Registered";
            if (retrievedPluginAssembly.Entities.Count > 0)
            {
                pluginAssemblyId = retrievedPluginAssembly.Entities[0].Id;
                assemblyToUpdate["pluginassemblyid"] = pluginAssemblyId;
                crmService.Update(assemblyToUpdate);
                operation = "Updated";
            }
            else
            {                
                pluginAssemblyId = Guid.NewGuid();
                assemblyToUpdate["pluginassemblyid"] = pluginAssemblyId;
                crmService.Create(assemblyToUpdate);
            }
            logMessages.Append(Environment.NewLine);
            logMessages.Append("Plugin Assembly :" + attributes[0] + " with " + pluginAssemblyId + " " + operation + " Successfully " + DateTime.Now.ToString());
            return pluginAssemblyId;
        }

        private EntityCollection RetrievePluginAssemblyByName(string pluginAssemblyName)
        {
            QueryExpression pluginAssemblyDetails = new QueryExpression("pluginassembly");
            pluginAssemblyDetails.ColumnSet = new ColumnSet(true);
            pluginAssemblyDetails.Criteria.AddCondition("name", ConditionOperator.Equal, pluginAssemblyName);
            var retrievedPluginAssembly = crmService.RetrieveMultiple(pluginAssemblyDetails);
            return retrievedPluginAssembly;
        }

        private  Guid GetMessageId(IOrganizationService service, XmlReader messageReader)
        {
            QueryExpression queryMessage = new QueryExpression("sdkmessage");
            queryMessage.ColumnSet = new ColumnSet(true);
            queryMessage.Criteria.AddCondition("name", ConditionOperator.Equal, messageReader["MessageName"]);
            var messageCollection = service.RetrieveMultiple(queryMessage);
            foreach (var message in messageCollection.Entities)
            {
                return message.Id;
            }
            return Guid.Empty;
        }
        private  Guid GetMessageFilterId(IOrganizationService service, XmlReader messageFilterReader, Guid messageId)
        {
            QueryExpression queryMessageFilter = new QueryExpression("sdkmessagefilter");
            queryMessageFilter.ColumnSet = new ColumnSet(true);
            if (messageFilterReader["PrimaryEntityName"] != null && messageFilterReader["PrimaryEntityName"] != "")
            {
                queryMessageFilter.Criteria.AddCondition("primaryobjecttypecode", ConditionOperator.Equal, messageFilterReader["PrimaryEntityName"]);
                queryMessageFilter.Criteria.AddCondition("sdkmessageid", ConditionOperator.Equal, messageId);
                var messageFilterCollection = service.RetrieveMultiple(queryMessageFilter);
                foreach (var messageFilter in messageFilterCollection.Entities)
                {
                    return messageFilter.Id;
                }
            }
            return Guid.Empty;
        }        
        private  void AddComponentToCRMSolution(Guid componentId, int componentType, string solutionUniqueName, IOrganizationService crmService)
        {
            if (!string.IsNullOrEmpty(solutionUniqueName))
            {
                AddSolutionComponentRequest addSolutionCompent = new AddSolutionComponentRequest();
                addSolutionCompent.ComponentId = componentId;
                addSolutionCompent.SolutionUniqueName = solutionUniqueName;
                addSolutionCompent.ComponentType = componentType;
                crmService.Execute(addSolutionCompent);
                logMessages.Append(Environment.NewLine);
                logMessages.Append("Component Type : " + componentType + ", with GUID : " + componentId + " added to solution " + solutionUniqueName);
            }
        }
    }
}