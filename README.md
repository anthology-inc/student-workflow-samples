# Introduction
This repository includes a set of CampusNexus workflow samples to help get started extending CampusNexus using Windows Workflow Foundation.

### To open a sample workflow
1. Open **CampusNexus Workflow Composer**
2. Within the **File** ribbon section, click **Open...**
3. Browse to the .xaml file you wish to import (e.g. Cmc.Nexus.Crm.Entities.TaskEntity_SavingEvent_Sample - Task Saving.xaml) and click **Open**
4. Apply any needed modifications to the Workflow

### To publish a Workflow
1. Within the **Server** ribon section, click **Publish...**
2. Check the **Enable this Workflow Version?** check box
3. Click the **Publish** button

## General
### General\Cmc.Nexus.Crm.Entities.TaskEntity_SavingEvent_Sample - Task Saving.xaml
This workflow demonstrates how to create a validation for a Saving event handler.

## Azure
### Azure\Cmc.Nexus.Crm.Entities.TaskEntity_SavedEvent_Sample - Azure Service Bus.xaml
This workflow demonstrates how to on-ramp messages to the [Azure Service Bus](https://docs.microsoft.com/en-us/azure/service-bus/).
### Azure\Cmc.Nexus.Crm.Entities.TaskEntity_SavingEvent_Sample - Azure Logic Apps.xaml
This workflow demonstrates how to invoke an [Azure Logic App](https://docs.microsoft.com/en-us/azure/logic-apps/) from within a CampusNexus Workflow.
1. Follow the steps above to open the sample Workflow
2. Modify the **Uri** property of the **Invoke Azure Logic App** activity to match the URI of your HTTP-triggered Azure Logic App
### Azure\Cmc.Nexus.Crm.Entities.TaskEntity_SavingEvent_Sample - Azure Functions.xaml
This workflow demonstrates how to invoke an [Azure Function](https://docs.microsoft.com/en-us/azure/azure-functions/) from within a CampusNexus Workflow.
1. Follow the steps above to open the sample Workflow
2. Modify the **Uri** property of the **Invoke Azure Function** activity to match the URI of your HTTP-triggered Azure Function
