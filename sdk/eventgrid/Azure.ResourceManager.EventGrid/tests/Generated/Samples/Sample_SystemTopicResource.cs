// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.EventGrid.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.EventGrid.Samples
{
    public partial class Sample_SystemTopicResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_SystemTopicsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/SystemTopics_Get.json
            // this example is just showing the usage of "SystemTopics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SystemTopicResource created on azure
            // for more information of creating SystemTopicResource, please refer to the document of SystemTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string systemTopicName = "exampleSystemTopic2";
            ResourceIdentifier systemTopicResourceId = SystemTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, systemTopicName);
            SystemTopicResource systemTopic = client.GetSystemTopicResource(systemTopicResourceId);

            // invoke the operation
            SystemTopicResource result = await systemTopic.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SystemTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_SystemTopicsDelete()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/SystemTopics_Delete.json
            // this example is just showing the usage of "SystemTopics_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SystemTopicResource created on azure
            // for more information of creating SystemTopicResource, please refer to the document of SystemTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string systemTopicName = "exampleSystemTopic1";
            ResourceIdentifier systemTopicResourceId = SystemTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, systemTopicName);
            SystemTopicResource systemTopic = client.GetSystemTopicResource(systemTopicResourceId);

            // invoke the operation
            await systemTopic.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_SystemTopicsUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/SystemTopics_Update.json
            // this example is just showing the usage of "SystemTopics_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this SystemTopicResource created on azure
            // for more information of creating SystemTopicResource, please refer to the document of SystemTopicResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string systemTopicName = "exampleSystemTopic1";
            ResourceIdentifier systemTopicResourceId = SystemTopicResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, systemTopicName);
            SystemTopicResource systemTopic = client.GetSystemTopicResource(systemTopicResourceId);

            // invoke the operation
            SystemTopicPatch patch = new SystemTopicPatch
            {
                Tags =
{
["tag1"] = "value1",
["tag2"] = "value2"
},
            };
            ArmOperation<SystemTopicResource> lro = await systemTopic.UpdateAsync(WaitUntil.Completed, patch);
            SystemTopicResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            SystemTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}
