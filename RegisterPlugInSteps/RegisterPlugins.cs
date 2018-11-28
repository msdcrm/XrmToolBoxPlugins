using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;
using Microsoft.Crm.Sdk.Messages;
using System.IO;
using System.Xml;

namespace RegisterPlugInSteps
{
    public partial class RegisterPlugins : PluginControlBase
    {
        private Settings mySettings;
        private string assemblyPathLocation = string.Empty;
        private string registrationStepsXML = string.Empty;
        private string solutionName = string.Empty;

        public RegisterPlugins()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }        

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void btnProcessRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                if (rtbRegistrationSteps.Text.Length == 0)
                {
                    MessageBox.Show(this, @"Please provide a valid plugin registration steps/xml before trying to register!", @"Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (rtbAssemblyPath.Text.Length == 0)
                {
                    MessageBox.Show(this, @"Please provide a valid path of Plugin Assembly!", @"Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                assemblyPathLocation = rtbAssemblyPath.Text;
                registrationStepsXML = rtbRegistrationSteps.Text;
                solutionName = rtbSolutionName.Text;
                ExecuteMethod(ProcessPlugInRegistrationSteps);
                //rtbRegistrationSteps.Text = registrationStepsXML;
            }
            catch (Exception error)
            {
                MessageBox.Show(this, @"An error occured: " + error.Message, @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ProcessPlugInRegistrationSteps()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Update plugin and Register plugin steps..",                
                Work = (bw, e) =>
                {                                   
                    RegisterPlugIns rp = new RegisterPlugIns(Service);                    
                    var response = rp.ProcessRegistration(assemblyPathLocation, solutionName, registrationStepsXML);
                    e.Result = response.ToString();                    
                },
                PostWorkCallBack = e =>
                {
                    if (e.Error == null)
                    {
                        rtbLogMessages.Text = e.Result.ToString();
                        rtbLogMessages.Visible = true;                        
                    }
                    else
                    {
                        MessageBox.Show(this, @"An error occured: " + e.Error.Message, @"Error", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            });
        }

        private void btnAddUpdatePlugin_Click(object sender, EventArgs e)
        {
            try
            {
                //if (rtbSolutionName.Text.Length == 0)
                //{
                //    MessageBox.Show(this, @"Please provide a valid solution name to register!", @"Warning",
                //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                if (rtbPlugInAssemblyPath.Text.Length == 0)
                {
                    MessageBox.Show(this, @"Please provide a valid path of Plugin Assembly!", @"Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                assemblyPathLocation = rtbPlugInAssemblyPath.Text;                
                solutionName = rtbSolutionName.Text;
                ExecuteMethod(AddOrUpdatePluginAssembly);
            }
            catch (Exception error)
            {
                MessageBox.Show(this, @"An error occured: " + error.Message, @"Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AddOrUpdatePluginAssembly()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Add/Update plugin assembly..",                
                Work = (bw, e) =>
                {
                    RegisterPlugIns rp = new RegisterPlugIns(Service);
                    var response = rp.AddOrUpdatePluginAssembly(assemblyPathLocation);
                    e.Result = response.ToString();
                },
                PostWorkCallBack = e =>
                {
                    if (e.Error == null)
                    {
                        rtbLogMessages.Text = e.Result.ToString();
                        rtbLogMessages.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show(this, @"An error occured: " + e.Error.Message, @"Error", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            });
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdBrowsePlugInAssembly.ShowDialog();
            if (result == DialogResult.OK) 
            {
                rtbPlugInAssemblyPath.Text = ofdBrowsePlugInAssembly.FileName;
            }
        }

        private void brnBrowsePluginAssemblyFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdPlugInFolder.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                rtbAssemblyPath.Text = Path.GetDirectoryName(ofdPlugInFolder.FileName);
            }
        }
    }
}