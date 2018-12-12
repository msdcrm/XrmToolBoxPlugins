# XrmToolBoxPlugins
1. This tool allows users to add or update plugin assembly by selecting plugin assembly full path, and selecting button Add/Update Plugin Assembly.
2. Adds plugin steps and corresponding images when registry file input has been given and Plugin assembly filder location.
3. Adds Plugin assembly and plugin steps to given CRM Solution name if present in CRM org.

# Sample Registry XML file content
https://github.com/msdcrm/XrmToolBoxPlugins/blob/master/RegisterPlugInSteps/CRMRegistryFile.xml

# How to Use
Function 1:

1. Please provide target steps xml (sample file content can be found in above link)
2. Browse/select target Plugin assembly folder location
3. Enter existing CRM solution name (optional)
4. Then select "Add/Update Plugin Assembly and Register Steps" button. 
This will add/update the plugin assembly and plugin steps as per given xml. If there is a solution in CRM with given name, Plugin Assembly and Steps are added to the corresponding solution.

Function 2:

1. Browse/Select "Plugin Assembly Full Path" (Ex: c:\pluginlib.dll)
2. Then select "Add/Update Plugin assembly" button. This will add/update the plugin assembly in Target CRM environment.
