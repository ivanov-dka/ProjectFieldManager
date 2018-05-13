## Project OnPremise/Online Enterprise Field Manager
This repository contains utility that can be used in the following scenarios:
- Move custom Enterprise Fields and Lookup Tables from one Project Environment to another
- Generate C# classes with constant values for all Enterprise Fields (in development)

Using this utility has a number of benefits over manually field creation:
- All your Environments (Dev\Test\Production) can have absolutely identical (including Guids) customizations
- Your consultants save time by moving customization between Environments in an automized way
- You can greatly improve deployment process of your Project solution

This utility is tested and verified for the listed platofrm versions:
- Project Online
- Project Server 2016

## Field Manager Options
### Export Enterprise Fields and Lookup Tables from your Environment
Export process is quite straightforward:
1. Launch utility and authorize PWA site
2. Select "Export Fields" option
3. On the new screen select al the fields and tables that you want to export. Use double click at table header to tick\untick all rows
4. Press "Start Export" button and select file path for saving. Later you should use this file for import to another pwa instance]
5. If everything works fine you'll see successfull export message box

### Import exported elements into another Environment
1. Launch utility and authorize PWA site
2. Select "Import Fields" option and choose file that was generated during file export process
3. On the new screen you can see all the fields and tables that were saved in the file. You can also tick the fields that are needed to be imported in the system. Use double click at table header to tick\untick all rows
4. Press "Start Export" button 
5. If everything works fine you'll see successfull import message box

### Generate C# classes
*coming soon*

### Special settings
#### Generate new Guids for imported fields
If you delete field from your Project instance reference to it belongs in the system database, so you are not able to create this field second time. If you're facing this issue you can tick "Generate new Guids" option on the import screen in order to recreate field successfully, although the Id property will be generated randomly and will not be longer equal to the value from export-file.
