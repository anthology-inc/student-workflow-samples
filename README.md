# Introduction
This repository includes a set of CampusNexus workflow samples to help get started extending CampusNexus using Windows Workflow Foundation.
## CustomActivities
CustomActivites is a Visual Studio solution containing custom workflow activities that can be used within CampusNexus Workflow.  This solution is composed of a standard Visual Studio [Activity Library](https://msdn.microsoft.com/en-us/library/dd489393.aspx) project that contains two activities:
1. **CodeConvertToJson** - a simple .NET *System.Activities.CodeActivity* that serializes an object to JSON
2. **XamlConvertToJson** - a simple .NET *System.Activities.Activity* designed using the Visual Studio Activity designer

Creating custom activities for use by CampusNexus is identical to creating activities using the Microsoft and Community authored tutorials and samples.  If you want the activities to show up in the toolbox of CampusNexus Workflow by default, you can add the **ExtensionAssembly** attribute to your AssemblyInfo.cs file as shown below.
```csharp
[assembly: ExtensionAssembly]
```
**Note: If you have a third party library, or you dont wan't to take a dependency on Cmc.Core, you can always add the custom activity library from within CampusNexus Workflow using the *Add Reference...* ribbon button.**
### Deployment
To deploy this solution, copy the **CustomActivities.dll** to the Workflow Composer (alongside WorkflowComposer.exe).  For runtime use, copy **CustomActivities.dll** to the **bin** folder (**bin\Extensions** for CampusNexus Student 21.0 or greater)
## Workflows
### To open a sample Workflow
1. Open **CampusNexus Workflow Composer**
2. Within the **File** ribbon section, click **Open...**
3. Browse to the .xaml file you wish to import (e.g. Cmc.Nexus.Crm.Entities.TaskEntity_SavingEvent_Sample - Task Saving.xaml) and click **Open**
4. Apply any needed modifications to the Workflow

### To publish a Workflow
1. Within the **Server** ribbon section, click **Publish...**
2. Check the **Enable this Workflow Version?** check box
3. Click the **Publish** button

### General
#### General\Cmc.Nexus.Crm.Entities.TaskEntity_SavingEvent_Sample - Task Saving.xaml
This workflow demonstrates how to create a validation for a Saving event handler.

### Azure
#### Azure\Cmc.Nexus.Crm.Entities.TaskEntity_SavedEvent_Sample - Azure Service Bus.xaml
This workflow demonstrates how to on-ramp messages to the [Azure Service Bus](https://docs.microsoft.com/en-us/azure/service-bus/).
The properties **ServiceBusNamespace**, **SharedAccessKey**, and **SharedAccessKeyName** are not required; however, if they are not provided the activity will pull these settings from the web.config appSettings section.  This is to allow workflows to be reused from environment to environment without modification.

Below is an example of the web.config app settings:
~~~~
<add key="azureServiceBus:serviceNamespace" value="nexus-student-integration-bus" />
<add key="azureServiceBus:sharedAccessKeyName" value="SendSharedAccessKey" />
<add key="azureServiceBus:sharedAccessKey" value="ZRXqcCfXQaGMi0FXTp6iNtFjMXKG+adnZTO3CcNAqDA=" />
~~~~

#### Azure\Cmc.Nexus.Crm.Entities.TaskEntity_SavingEvent_Sample - Azure Logic Apps.xaml
This workflow demonstrates how to invoke an [Azure Logic App](https://docs.microsoft.com/en-us/azure/logic-apps/) from within a CampusNexus Workflow.
1. Follow the steps above to open the sample Workflow
2. Modify the **Uri** property of the **Invoke Azure Logic App** activity to match the URI of your HTTP-triggered Azure Logic App
#### Azure\Cmc.Nexus.Crm.Entities.TaskEntity_SavingEvent_Sample - Azure Functions.xaml
This workflow demonstrates how to invoke an [Azure Function](https://docs.microsoft.com/en-us/azure/azure-functions/) from within a CampusNexus Workflow.
1. Follow the steps above to open the sample Workflow
2. Modify the **Uri** property of the **Invoke Azure Function** activity to match the URI of your HTTP-triggered Azure Function
