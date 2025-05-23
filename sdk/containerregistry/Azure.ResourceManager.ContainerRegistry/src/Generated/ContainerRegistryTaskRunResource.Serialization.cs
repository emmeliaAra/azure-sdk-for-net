// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ContainerRegistry
{
    public partial class ContainerRegistryTaskRunResource : IJsonModel<ContainerRegistryTaskRunData>
    {
        void IJsonModel<ContainerRegistryTaskRunData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ContainerRegistryTaskRunData>)Data).Write(writer, options);

        ContainerRegistryTaskRunData IJsonModel<ContainerRegistryTaskRunData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ContainerRegistryTaskRunData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ContainerRegistryTaskRunData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ContainerRegistryTaskRunData>(Data, options, AzureResourceManagerContainerRegistryContext.Default);

        ContainerRegistryTaskRunData IPersistableModel<ContainerRegistryTaskRunData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ContainerRegistryTaskRunData>(data, options, AzureResourceManagerContainerRegistryContext.Default);

        string IPersistableModel<ContainerRegistryTaskRunData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ContainerRegistryTaskRunData>)Data).GetFormatFromOptions(options);
    }
}
