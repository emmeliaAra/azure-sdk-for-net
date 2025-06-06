// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Hci
{
    public partial class HciClusterSecuritySettingResource : IJsonModel<HciClusterSecuritySettingData>
    {
        private static HciClusterSecuritySettingData s_dataDeserializationInstance;
        private static HciClusterSecuritySettingData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<HciClusterSecuritySettingData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<HciClusterSecuritySettingData>)Data).Write(writer, options);

        HciClusterSecuritySettingData IJsonModel<HciClusterSecuritySettingData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<HciClusterSecuritySettingData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<HciClusterSecuritySettingData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<HciClusterSecuritySettingData>(Data, options, AzureResourceManagerHciContext.Default);

        HciClusterSecuritySettingData IPersistableModel<HciClusterSecuritySettingData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<HciClusterSecuritySettingData>(data, options, AzureResourceManagerHciContext.Default);

        string IPersistableModel<HciClusterSecuritySettingData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<HciClusterSecuritySettingData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
