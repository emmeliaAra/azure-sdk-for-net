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
    public partial class Sample_NamespaceTopicCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_NamespaceTopicsCreateOrUpdate()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/NamespaceTopics_CreateOrUpdate.json
            // this example is just showing the usage of "NamespaceTopics_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "examplenamespace2";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this NamespaceTopicResource
            NamespaceTopicCollection collection = eventGridNamespace.GetNamespaceTopics();

            // invoke the operation
            string topicName = "examplenamespacetopic2";
            NamespaceTopicData data = new NamespaceTopicData
            {
                PublisherType = PublisherType.Custom,
                InputSchema = EventInputSchema.CloudEventSchemaV10,
                EventRetentionInDays = 1,
            };
            ArmOperation<NamespaceTopicResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, topicName, data);
            NamespaceTopicResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NamespaceTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_NamespaceTopicsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/NamespaceTopics_Get.json
            // this example is just showing the usage of "NamespaceTopics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e41";
            string resourceGroupName = "examplerg";
            string namespaceName = "examplenamespace2";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this NamespaceTopicResource
            NamespaceTopicCollection collection = eventGridNamespace.GetNamespaceTopics();

            // invoke the operation
            string topicName = "examplenamespacetopic2";
            NamespaceTopicResource result = await collection.GetAsync(topicName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NamespaceTopicData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_NamespaceTopicsListByNamespace()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/NamespaceTopics_ListByNamespace.json
            // this example is just showing the usage of "NamespaceTopics_ListByNamespace" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e40";
            string resourceGroupName = "examplerg";
            string namespaceName = "examplenamespace2";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this NamespaceTopicResource
            NamespaceTopicCollection collection = eventGridNamespace.GetNamespaceTopics();

            // invoke the operation and iterate over the result
            await foreach (NamespaceTopicResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NamespaceTopicData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_NamespaceTopicsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/NamespaceTopics_Get.json
            // this example is just showing the usage of "NamespaceTopics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e41";
            string resourceGroupName = "examplerg";
            string namespaceName = "examplenamespace2";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this NamespaceTopicResource
            NamespaceTopicCollection collection = eventGridNamespace.GetNamespaceTopics();

            // invoke the operation
            string topicName = "examplenamespacetopic2";
            bool result = await collection.ExistsAsync(topicName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_NamespaceTopicsGet()
        {
            // Generated from example definition: specification/eventgrid/resource-manager/Microsoft.EventGrid/preview/2025-04-01-preview/examples/NamespaceTopics_Get.json
            // this example is just showing the usage of "NamespaceTopics_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this EventGridNamespaceResource created on azure
            // for more information of creating EventGridNamespaceResource, please refer to the document of EventGridNamespaceResource
            string subscriptionId = "8f6b6269-84f2-4d09-9e31-1127efcd1e41";
            string resourceGroupName = "examplerg";
            string namespaceName = "examplenamespace2";
            ResourceIdentifier eventGridNamespaceResourceId = EventGridNamespaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, namespaceName);
            EventGridNamespaceResource eventGridNamespace = client.GetEventGridNamespaceResource(eventGridNamespaceResourceId);

            // get the collection of this NamespaceTopicResource
            NamespaceTopicCollection collection = eventGridNamespace.GetNamespaceTopics();

            // invoke the operation
            string topicName = "examplenamespacetopic2";
            NullableResponse<NamespaceTopicResource> response = await collection.GetIfExistsAsync(topicName);
            NamespaceTopicResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NamespaceTopicData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
