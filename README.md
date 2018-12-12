# XrmToolBoxPlugins
1. This tool allows users to add or update plugin assembly by selecting plugin assembly full path, and selecting button Add/Update Plugin Assembly.
2. Adds plugin steps and corresponding images when registry file input has been given and Plugin assembly filder location.
3. Adds Plugin assembly and plugin steps to given CRM Solution name if present in CRM org.

Sample Registry XML file
--------------------------------------
<?xml version="1.0"?>
<Register xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns="http://schemas.microsoft.com/crm/2011/tools/pluginregistration">
  <Solutions>
    <Solution Assembly="PlugInLib.dll" Id="9EA64C8E-2B1A-4E6C-BE9A-E3CDEEFEC9B1" IsolationMode="Sandbox" SourceType="Database">
      <PluginTypes>
        <Plugin Description="Postupdate of Test" FriendlyName="Postupdate of Test" Name="PlugInLib.PostUpdateTest" Id="886C91F9-BBE9-4382-A767-59515E67E302" TypeName="PlugInLib.PostUpdateTest">
          <Steps>
            <clear />
            <Step AsyncAutoDelete="true" Name="Update of Test" Description="Update of Test" FilteringAttributes="new_name" Id="6668C52D-C0C7-49C7-9448-8DF4A8CF233A" ImpersonatingUserId="00000000-0000-0000-0000-000000000000" MessageName="Update" Mode="Synchronous" PrimaryEntityName="new_test" Rank="1" Stage="PostOutsideTransaction" SupportedDeployment="ServerOnly" MessageEntityId="00000000-0000-0000-0000-000000000000">              
              <Images>
                <Image Attributes="new_name" EntityAlias="PostImage" Id="2CD49FD0-5EC0-470B-A980-22DEF933B43E" MessagePropertyName="Target" ImageType="PostImage" />
                <Image Attributes="new_name" EntityAlias="PreImage" Id="949BC9EB-B9BB-46AF-90E3-68DAED07A3C0" MessagePropertyName="Target" ImageType="PreImage" />
              </Images>
            </Step>            
          </Steps>
        </Plugin>
      </PluginTypes>
    </Solution>
    </Solutions>    
  <XamlWorkflows />
</Register>
