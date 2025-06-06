// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightAutoScaleConfiguration : IUtf8JsonSerializable, IJsonModel<HDInsightAutoScaleConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightAutoScaleConfiguration>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<HDInsightAutoScaleConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAutoScaleConfiguration)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteObjectValue(Capacity, options);
            }
            if (Optional.IsDefined(Recurrence))
            {
                writer.WritePropertyName("recurrence"u8);
                writer.WriteObjectValue(Recurrence, options);
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

        HDInsightAutoScaleConfiguration IJsonModel<HDInsightAutoScaleConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAutoScaleConfiguration)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightAutoScaleConfiguration(document.RootElement, options);
        }

        internal static HDInsightAutoScaleConfiguration DeserializeHDInsightAutoScaleConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HDInsightAutoScaleCapacity capacity = default;
            HDInsightAutoScaleRecurrence recurrence = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = HDInsightAutoScaleCapacity.DeserializeHDInsightAutoScaleCapacity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("recurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recurrence = HDInsightAutoScaleRecurrence.DeserializeHDInsightAutoScaleRecurrence(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new HDInsightAutoScaleConfiguration(capacity, recurrence, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightAutoScaleConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHDInsightContext.Default);
                default:
                    throw new FormatException($"The model {nameof(HDInsightAutoScaleConfiguration)} does not support writing '{options.Format}' format.");
            }
        }

        HDInsightAutoScaleConfiguration IPersistableModel<HDInsightAutoScaleConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeHDInsightAutoScaleConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightAutoScaleConfiguration)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightAutoScaleConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
