// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Cdn
{
    public partial class FrontDoorSecurityPolicyResource : IJsonModel<FrontDoorSecurityPolicyData>
    {
        private static FrontDoorSecurityPolicyData s_dataDeserializationInstance;
        private static FrontDoorSecurityPolicyData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<FrontDoorSecurityPolicyData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FrontDoorSecurityPolicyData>)Data).Write(writer, options);

        FrontDoorSecurityPolicyData IJsonModel<FrontDoorSecurityPolicyData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FrontDoorSecurityPolicyData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<FrontDoorSecurityPolicyData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<FrontDoorSecurityPolicyData>(Data, options, AzureResourceManagerCdnContext.Default);

        FrontDoorSecurityPolicyData IPersistableModel<FrontDoorSecurityPolicyData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FrontDoorSecurityPolicyData>(data, options, AzureResourceManagerCdnContext.Default);

        string IPersistableModel<FrontDoorSecurityPolicyData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FrontDoorSecurityPolicyData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
