// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.IotFirmwareDefense.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.IotFirmwareDefense.Samples
{
    public partial class Sample_IotFirmwareResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_FirmwaresGetMaximumSetGenGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/Firmwares_Get_MaximumSet_Gen.json
            // this example is just showing the usage of "Firmwares_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "5C707B5F-6130-4F71-819E-953A28942E88";
            string resourceGroupName = "rgiotfirmwaredefense";
            string workspaceName = "exampleWorkspaceName";
            string firmwareId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation
            IotFirmwareResource result = await iotFirmware.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotFirmwareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_FirmwaresGetMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/Firmwares_Get_MinimumSet_Gen.json
            // this example is just showing the usage of "Firmwares_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "685C0C6F-9867-4B1C-A534-AA3A05B54BCE";
            string resourceGroupName = "rgworkspaces-firmwares";
            string workspaceName = "A7";
            string firmwareId = "umrkdttp";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation
            IotFirmwareResource result = await iotFirmware.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotFirmwareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_FirmwaresDeleteMaximumSetGenGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/Firmwares_Delete_MaximumSet_Gen.json
            // this example is just showing the usage of "Firmwares_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "5C707B5F-6130-4F71-819E-953A28942E88";
            string resourceGroupName = "rgiotfirmwaredefense";
            string workspaceName = "exampleWorkspaceName";
            string firmwareId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation
            await iotFirmware.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_FirmwaresDeleteMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/Firmwares_Delete_MinimumSet_Gen.json
            // this example is just showing the usage of "Firmwares_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "685C0C6F-9867-4B1C-A534-AA3A05B54BCE";
            string resourceGroupName = "rgworkspaces-firmwares";
            string workspaceName = "A7";
            string firmwareId = "umrkdttp";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation
            await iotFirmware.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_FirmwaresUpdateMaximumSetGenGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/Firmwares_Update_MaximumSet_Gen.json
            // this example is just showing the usage of "Firmwares_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "5C707B5F-6130-4F71-819E-953A28942E88";
            string resourceGroupName = "rgiotfirmwaredefense";
            string workspaceName = "exampleWorkspaceName";
            string firmwareId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation
            IotFirmwarePatch patch = new IotFirmwarePatch
            {
                FileName = "dmnqhyxssutvnewntlb",
                Vendor = "hymojocxpxqhtblioaavylnzyg",
                Model = "wmyfbyjsggbvxcuin",
                Version = "nhtxzslgcbtptu",
                Description = "nknvqnkgumzbupxe",
                FileSize = 30L,
                Status = FirmwareAnalysisStatus.Pending,
                StatusMessages = {new FirmwareAnalysisStatusMessage
{
ErrorCode = 20L,
Message = "edtylkjvj",
}},
            };
            IotFirmwareResource result = await iotFirmware.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotFirmwareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_FirmwaresUpdateMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/Firmwares_Update_MinimumSet_Gen.json
            // this example is just showing the usage of "Firmwares_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "685C0C6F-9867-4B1C-A534-AA3A05B54BCE";
            string resourceGroupName = "rgworkspaces-firmwares";
            string workspaceName = "A7";
            string firmwareId = "umrkdttp";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation
            IotFirmwarePatch patch = new IotFirmwarePatch();
            IotFirmwareResource result = await iotFirmware.UpdateAsync(patch);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            IotFirmwareData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetBinaryHardeningResults_BinaryHardeningListByFirmwareMaximumSetGenGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/BinaryHardening_ListByFirmware_MaximumSet_Gen.json
            // this example is just showing the usage of "BinaryHardening_ListByFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "5C707B5F-6130-4F71-819E-953A28942E88";
            string resourceGroupName = "rgiotfirmwaredefense";
            string workspaceName = "exampleWorkspaceName";
            string firmwareId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation and iterate over the result
            await foreach (BinaryHardeningResult item in iotFirmware.GetBinaryHardeningResultsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetBinaryHardeningResults_BinaryHardeningListByFirmwareMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/BinaryHardening_ListByFirmware_MinimumSet_Gen.json
            // this example is just showing the usage of "BinaryHardening_ListByFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation and iterate over the result
            await foreach (BinaryHardeningResult item in iotFirmware.GetBinaryHardeningResultsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetCommonVulnerabilitiesAndExposures_CvesListByFirmwareMaximumSetGenGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/Cves_ListByFirmware_MaximumSet_Gen.json
            // this example is just showing the usage of "Cves_ListByFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "5C707B5F-6130-4F71-819E-953A28942E88";
            string resourceGroupName = "rgiotfirmwaredefense";
            string workspaceName = "exampleWorkspaceName";
            string firmwareId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation and iterate over the result
            await foreach (CveResult item in iotFirmware.GetCommonVulnerabilitiesAndExposuresAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetCommonVulnerabilitiesAndExposures_CvesListByFirmwareMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/Cves_ListByFirmware_MinimumSet_Gen.json
            // this example is just showing the usage of "Cves_ListByFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation and iterate over the result
            await foreach (CveResult item in iotFirmware.GetCommonVulnerabilitiesAndExposuresAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetCryptoCertificates_CryptoCertificatesListByFirmwareMaximumSetGenGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/CryptoCertificates_ListByFirmware_MaximumSet_Gen.json
            // this example is just showing the usage of "CryptoCertificates_ListByFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "5C707B5F-6130-4F71-819E-953A28942E88";
            string resourceGroupName = "rgiotfirmwaredefense";
            string workspaceName = "exampleWorkspaceName";
            string firmwareId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation and iterate over the result
            await foreach (CryptoCertificateResult item in iotFirmware.GetCryptoCertificatesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetCryptoCertificates_CryptoCertificatesListByFirmwareMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/CryptoCertificates_ListByFirmware_MinimumSet_Gen.json
            // this example is just showing the usage of "CryptoCertificates_ListByFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation and iterate over the result
            await foreach (CryptoCertificateResult item in iotFirmware.GetCryptoCertificatesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetCryptoKeys_CryptoKeysListByFirmwareMaximumSetGenGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/CryptoKeys_ListByFirmware_MaximumSet_Gen.json
            // this example is just showing the usage of "CryptoKeys_ListByFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "5C707B5F-6130-4F71-819E-953A28942E88";
            string resourceGroupName = "rgiotfirmwaredefense";
            string workspaceName = "exampleWorkspaceName";
            string firmwareId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation and iterate over the result
            await foreach (CryptoKeyResult item in iotFirmware.GetCryptoKeysAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetCryptoKeys_CryptoKeysListByFirmwareMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/CryptoKeys_ListByFirmware_MinimumSet_Gen.json
            // this example is just showing the usage of "CryptoKeys_ListByFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation and iterate over the result
            await foreach (CryptoKeyResult item in iotFirmware.GetCryptoKeysAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetPasswordHashes_PasswordHashesListByFirmwareMaximumSetGenGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/PasswordHashes_ListByFirmware_MaximumSet_Gen.json
            // this example is just showing the usage of "PasswordHashes_ListByFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "5C707B5F-6130-4F71-819E-953A28942E88";
            string resourceGroupName = "rgiotfirmwaredefense";
            string workspaceName = "exampleWorkspaceName";
            string firmwareId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation and iterate over the result
            await foreach (PasswordHashResult item in iotFirmware.GetPasswordHashesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetPasswordHashes_PasswordHashesListByFirmwareMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/PasswordHashes_ListByFirmware_MinimumSet_Gen.json
            // this example is just showing the usage of "PasswordHashes_ListByFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation and iterate over the result
            await foreach (PasswordHashResult item in iotFirmware.GetPasswordHashesAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSbomComponents_SbomComponentsListByFirmwareMaximumSetGenGeneratedByMaximumSetRule()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/SbomComponents_ListByFirmware_MaximumSet_Gen.json
            // this example is just showing the usage of "SbomComponents_ListByFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "5C707B5F-6130-4F71-819E-953A28942E88";
            string resourceGroupName = "rgiotfirmwaredefense";
            string workspaceName = "exampleWorkspaceName";
            string firmwareId = "00000000-0000-0000-0000-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation and iterate over the result
            await foreach (SbomComponentResult item in iotFirmware.GetSbomComponentsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetSbomComponents_SbomComponentsListByFirmwareMinimumSetGen()
        {
            // Generated from example definition: specification/fist/resource-manager/Microsoft.IoTFirmwareDefense/preview/2025-04-01-preview/examples/SbomComponents_ListByFirmware_MinimumSet_Gen.json
            // this example is just showing the usage of "SbomComponents_ListByFirmware" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this IotFirmwareResource created on azure
            // for more information of creating IotFirmwareResource, please refer to the document of IotFirmwareResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "FirmwareAnalysisRG";
            string workspaceName = "default";
            string firmwareId = "109a9886-50bf-85a8-9d75-000000000000";
            ResourceIdentifier iotFirmwareResourceId = IotFirmwareResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, workspaceName, firmwareId);
            IotFirmwareResource iotFirmware = client.GetIotFirmwareResource(iotFirmwareResourceId);

            // invoke the operation and iterate over the result
            await foreach (SbomComponentResult item in iotFirmware.GetSbomComponentsAsync())
            {
                Console.WriteLine($"Succeeded: {item}");
            }

            Console.WriteLine("Succeeded");
        }
    }
}
