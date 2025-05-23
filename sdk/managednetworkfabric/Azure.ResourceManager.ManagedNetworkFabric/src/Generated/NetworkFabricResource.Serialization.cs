// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkFabricResource : IJsonModel<NetworkFabricData>
    {
        void IJsonModel<NetworkFabricData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NetworkFabricData>)Data).Write(writer, options);

        NetworkFabricData IJsonModel<NetworkFabricData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NetworkFabricData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<NetworkFabricData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<NetworkFabricData>(Data, options, AzureResourceManagerManagedNetworkFabricContext.Default);

        NetworkFabricData IPersistableModel<NetworkFabricData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NetworkFabricData>(data, options, AzureResourceManagerManagedNetworkFabricContext.Default);

        string IPersistableModel<NetworkFabricData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NetworkFabricData>)Data).GetFormatFromOptions(options);
    }
}
