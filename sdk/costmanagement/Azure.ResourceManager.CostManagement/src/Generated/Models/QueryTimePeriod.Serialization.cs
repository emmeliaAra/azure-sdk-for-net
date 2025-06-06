// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class QueryTimePeriod : IUtf8JsonSerializable, IJsonModel<QueryTimePeriod>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<QueryTimePeriod>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<QueryTimePeriod>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryTimePeriod>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryTimePeriod)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("from"u8);
            writer.WriteStringValue(From, "O");
            writer.WritePropertyName("to"u8);
            writer.WriteStringValue(To, "O");
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

        QueryTimePeriod IJsonModel<QueryTimePeriod>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryTimePeriod>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(QueryTimePeriod)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeQueryTimePeriod(document.RootElement, options);
        }

        internal static QueryTimePeriod DeserializeQueryTimePeriod(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset @from = default;
            DateTimeOffset to = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("from"u8))
                {
                    @from = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("to"u8))
                {
                    to = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new QueryTimePeriod(@from, to, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<QueryTimePeriod>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryTimePeriod>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerCostManagementContext.Default);
                default:
                    throw new FormatException($"The model {nameof(QueryTimePeriod)} does not support writing '{options.Format}' format.");
            }
        }

        QueryTimePeriod IPersistableModel<QueryTimePeriod>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<QueryTimePeriod>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeQueryTimePeriod(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(QueryTimePeriod)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<QueryTimePeriod>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
