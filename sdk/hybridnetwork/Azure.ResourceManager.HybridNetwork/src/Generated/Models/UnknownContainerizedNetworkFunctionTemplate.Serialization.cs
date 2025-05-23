// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    internal partial class UnknownContainerizedNetworkFunctionTemplate : IUtf8JsonSerializable, IJsonModel<ContainerizedNetworkFunctionTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerizedNetworkFunctionTemplate>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerizedNetworkFunctionTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerizedNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerizedNetworkFunctionTemplate)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        ContainerizedNetworkFunctionTemplate IJsonModel<ContainerizedNetworkFunctionTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerizedNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerizedNetworkFunctionTemplate)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerizedNetworkFunctionTemplate(document.RootElement, options);
        }

        internal static UnknownContainerizedNetworkFunctionTemplate DeserializeUnknownContainerizedNetworkFunctionTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerizedNetworkFunctionNfviType nfviType = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nfviType"u8))
                {
                    nfviType = new ContainerizedNetworkFunctionNfviType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownContainerizedNetworkFunctionTemplate(nfviType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerizedNetworkFunctionTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerizedNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHybridNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ContainerizedNetworkFunctionTemplate)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerizedNetworkFunctionTemplate IPersistableModel<ContainerizedNetworkFunctionTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerizedNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerizedNetworkFunctionTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerizedNetworkFunctionTemplate)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerizedNetworkFunctionTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
