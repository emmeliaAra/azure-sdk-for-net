// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class BgpConnectionResource : IJsonModel<BgpConnectionData>
    {
        private static BgpConnectionData s_dataDeserializationInstance;
        private static BgpConnectionData DataDeserializationInstance => s_dataDeserializationInstance ??= new();

        void IJsonModel<BgpConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<BgpConnectionData>)Data).Write(writer, options);

        BgpConnectionData IJsonModel<BgpConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<BgpConnectionData>)DataDeserializationInstance).Create(ref reader, options);

        BinaryData IPersistableModel<BgpConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<BgpConnectionData>(Data, options, AzureResourceManagerNetworkContext.Default);

        BgpConnectionData IPersistableModel<BgpConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<BgpConnectionData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<BgpConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<BgpConnectionData>)DataDeserializationInstance).GetFormatFromOptions(options);
    }
}
