// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class BareMetalMachinePowerOffContent : IUtf8JsonSerializable, IJsonModel<BareMetalMachinePowerOffContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BareMetalMachinePowerOffContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BareMetalMachinePowerOffContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachinePowerOffContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BareMetalMachinePowerOffContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(SkipShutdown))
            {
                writer.WritePropertyName("skipShutdown"u8);
                writer.WriteStringValue(SkipShutdown.Value.ToString());
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        BareMetalMachinePowerOffContent IJsonModel<BareMetalMachinePowerOffContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachinePowerOffContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BareMetalMachinePowerOffContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBareMetalMachinePowerOffContent(document.RootElement, options);
        }

        internal static BareMetalMachinePowerOffContent DeserializeBareMetalMachinePowerOffContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            BareMetalMachineSkipShutdown? skipShutdown = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skipShutdown"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipShutdown = new BareMetalMachineSkipShutdown(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BareMetalMachinePowerOffContent(skipShutdown, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BareMetalMachinePowerOffContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachinePowerOffContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkCloudContext.Default);
                default:
                    throw new FormatException($"The model {nameof(BareMetalMachinePowerOffContent)} does not support writing '{options.Format}' format.");
            }
        }

        BareMetalMachinePowerOffContent IPersistableModel<BareMetalMachinePowerOffContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BareMetalMachinePowerOffContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeBareMetalMachinePowerOffContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BareMetalMachinePowerOffContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BareMetalMachinePowerOffContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
