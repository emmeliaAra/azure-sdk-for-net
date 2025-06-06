﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningPrivateEndpoint : IUtf8JsonSerializable, IJsonModel<MachineLearningPrivateEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningPrivateEndpoint>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningPrivateEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningPrivateEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningPrivateEndpoint)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Optional.IsDefined(SubnetArmId))
            {
                writer.WritePropertyName("subnetArmId"u8);
                writer.WriteStringValue(SubnetArmId);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MachineLearningPrivateEndpoint IJsonModel<MachineLearningPrivateEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningPrivateEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningPrivateEndpoint)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningPrivateEndpoint(document.RootElement, options);
        }

        internal static MachineLearningPrivateEndpoint DeserializeMachineLearningPrivateEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            ResourceIdentifier subnetArmId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subnetArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningPrivateEndpoint(id, subnetArmId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningPrivateEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningPrivateEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningPrivateEndpoint)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningPrivateEndpoint IPersistableModel<MachineLearningPrivateEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningPrivateEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningPrivateEndpoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningPrivateEndpoint)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningPrivateEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
