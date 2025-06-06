// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Network.Samples
{
    public partial class Sample_NetworkInterfaceTapConfigurationCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_CreateNetworkInterfaceTapConfigurations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/NetworkInterfaceTapConfigurationCreate.json
            // this example is just showing the usage of "NetworkInterfaceTapConfigurations_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkInterfaceResource created on azure
            // for more information of creating NetworkInterfaceResource, please refer to the document of NetworkInterfaceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string networkInterfaceName = "mynic";
            ResourceIdentifier networkInterfaceResourceId = NetworkInterfaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkInterfaceName);
            NetworkInterfaceResource networkInterface = client.GetNetworkInterfaceResource(networkInterfaceResourceId);

            // get the collection of this NetworkInterfaceTapConfigurationResource
            NetworkInterfaceTapConfigurationCollection collection = networkInterface.GetNetworkInterfaceTapConfigurations();

            // invoke the operation
            string tapConfigurationName = "tapconfiguration1";
            NetworkInterfaceTapConfigurationData data = new NetworkInterfaceTapConfigurationData
            {
                VirtualNetworkTap = new VirtualNetworkTapData
                {
                    Id = new ResourceIdentifier("/subscriptions/subid/resourceGroups/testrg/providers/Microsoft.Network/virtualNetworkTaps/testvtap"),
                },
            };
            ArmOperation<NetworkInterfaceTapConfigurationResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, tapConfigurationName, data);
            NetworkInterfaceTapConfigurationResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkInterfaceTapConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetNetworkInterfaceTapConfigurations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/NetworkInterfaceTapConfigurationGet.json
            // this example is just showing the usage of "NetworkInterfaceTapConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkInterfaceResource created on azure
            // for more information of creating NetworkInterfaceResource, please refer to the document of NetworkInterfaceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string networkInterfaceName = "mynic";
            ResourceIdentifier networkInterfaceResourceId = NetworkInterfaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkInterfaceName);
            NetworkInterfaceResource networkInterface = client.GetNetworkInterfaceResource(networkInterfaceResourceId);

            // get the collection of this NetworkInterfaceTapConfigurationResource
            NetworkInterfaceTapConfigurationCollection collection = networkInterface.GetNetworkInterfaceTapConfigurations();

            // invoke the operation
            string tapConfigurationName = "tapconfiguration1";
            NetworkInterfaceTapConfigurationResource result = await collection.GetAsync(tapConfigurationName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            NetworkInterfaceTapConfigurationData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_ListVirtualNetworkTapConfigurations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/NetworkInterfaceTapConfigurationList.json
            // this example is just showing the usage of "NetworkInterfaceTapConfigurations_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkInterfaceResource created on azure
            // for more information of creating NetworkInterfaceResource, please refer to the document of NetworkInterfaceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string networkInterfaceName = "mynic";
            ResourceIdentifier networkInterfaceResourceId = NetworkInterfaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkInterfaceName);
            NetworkInterfaceResource networkInterface = client.GetNetworkInterfaceResource(networkInterfaceResourceId);

            // get the collection of this NetworkInterfaceTapConfigurationResource
            NetworkInterfaceTapConfigurationCollection collection = networkInterface.GetNetworkInterfaceTapConfigurations();

            // invoke the operation and iterate over the result
            await foreach (NetworkInterfaceTapConfigurationResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkInterfaceTapConfigurationData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_GetNetworkInterfaceTapConfigurations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/NetworkInterfaceTapConfigurationGet.json
            // this example is just showing the usage of "NetworkInterfaceTapConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkInterfaceResource created on azure
            // for more information of creating NetworkInterfaceResource, please refer to the document of NetworkInterfaceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string networkInterfaceName = "mynic";
            ResourceIdentifier networkInterfaceResourceId = NetworkInterfaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkInterfaceName);
            NetworkInterfaceResource networkInterface = client.GetNetworkInterfaceResource(networkInterfaceResourceId);

            // get the collection of this NetworkInterfaceTapConfigurationResource
            NetworkInterfaceTapConfigurationCollection collection = networkInterface.GetNetworkInterfaceTapConfigurations();

            // invoke the operation
            string tapConfigurationName = "tapconfiguration1";
            bool result = await collection.ExistsAsync(tapConfigurationName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_GetNetworkInterfaceTapConfigurations()
        {
            // Generated from example definition: specification/network/resource-manager/Microsoft.Network/stable/2024-07-01/examples/NetworkInterfaceTapConfigurationGet.json
            // this example is just showing the usage of "NetworkInterfaceTapConfigurations_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NetworkInterfaceResource created on azure
            // for more information of creating NetworkInterfaceResource, please refer to the document of NetworkInterfaceResource
            string subscriptionId = "subid";
            string resourceGroupName = "testrg";
            string networkInterfaceName = "mynic";
            ResourceIdentifier networkInterfaceResourceId = NetworkInterfaceResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, networkInterfaceName);
            NetworkInterfaceResource networkInterface = client.GetNetworkInterfaceResource(networkInterfaceResourceId);

            // get the collection of this NetworkInterfaceTapConfigurationResource
            NetworkInterfaceTapConfigurationCollection collection = networkInterface.GetNetworkInterfaceTapConfigurations();

            // invoke the operation
            string tapConfigurationName = "tapconfiguration1";
            NullableResponse<NetworkInterfaceTapConfigurationResource> response = await collection.GetIfExistsAsync(tapConfigurationName);
            NetworkInterfaceTapConfigurationResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                NetworkInterfaceTapConfigurationData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
