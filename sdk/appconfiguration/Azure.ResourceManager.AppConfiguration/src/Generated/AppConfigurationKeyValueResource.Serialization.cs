// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppConfiguration
{
    public partial class AppConfigurationKeyValueResource : IJsonModel<AppConfigurationKeyValueData>
    {
        void IJsonModel<AppConfigurationKeyValueData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AppConfigurationKeyValueData>)Data).Write(writer, options);

        AppConfigurationKeyValueData IJsonModel<AppConfigurationKeyValueData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AppConfigurationKeyValueData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AppConfigurationKeyValueData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<AppConfigurationKeyValueData>(Data, options, AzureResourceManagerAppConfigurationContext.Default);

        AppConfigurationKeyValueData IPersistableModel<AppConfigurationKeyValueData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AppConfigurationKeyValueData>(data, options, AzureResourceManagerAppConfigurationContext.Default);

        string IPersistableModel<AppConfigurationKeyValueData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AppConfigurationKeyValueData>)Data).GetFormatFromOptions(options);
    }
}
