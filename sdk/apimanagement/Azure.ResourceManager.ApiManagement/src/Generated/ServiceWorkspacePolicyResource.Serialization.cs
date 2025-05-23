// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ServiceWorkspacePolicyResource : IJsonModel<PolicyContractData>
    {
        void IJsonModel<PolicyContractData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PolicyContractData>)Data).Write(writer, options);

        PolicyContractData IJsonModel<PolicyContractData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PolicyContractData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<PolicyContractData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<PolicyContractData>(Data, options, AzureResourceManagerApiManagementContext.Default);

        PolicyContractData IPersistableModel<PolicyContractData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PolicyContractData>(data, options, AzureResourceManagerApiManagementContext.Default);

        string IPersistableModel<PolicyContractData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PolicyContractData>)Data).GetFormatFromOptions(options);
    }
}
