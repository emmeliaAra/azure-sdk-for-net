// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Compute
{
    internal class GalleryInVmAccessControlProfileVersionOperationSource : IOperationSource<GalleryInVmAccessControlProfileVersionResource>
    {
        private readonly ArmClient _client;

        internal GalleryInVmAccessControlProfileVersionOperationSource(ArmClient client)
        {
            _client = client;
        }

        GalleryInVmAccessControlProfileVersionResource IOperationSource<GalleryInVmAccessControlProfileVersionResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<GalleryInVmAccessControlProfileVersionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerComputeContext.Default);
            return new GalleryInVmAccessControlProfileVersionResource(_client, data);
        }

        async ValueTask<GalleryInVmAccessControlProfileVersionResource> IOperationSource<GalleryInVmAccessControlProfileVersionResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<GalleryInVmAccessControlProfileVersionData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerComputeContext.Default);
            return await Task.FromResult(new GalleryInVmAccessControlProfileVersionResource(_client, data)).ConfigureAwait(false);
        }
    }
}
