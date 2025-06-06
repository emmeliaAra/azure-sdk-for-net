// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MachineLearningServicesDatasetDriftDetectedEventDataConverter))]
    public partial class MachineLearningServicesDatasetDriftDetectedEventData : IUtf8JsonSerializable, IJsonModel<MachineLearningServicesDatasetDriftDetectedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningServicesDatasetDriftDetectedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningServicesDatasetDriftDetectedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicesDatasetDriftDetectedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServicesDatasetDriftDetectedEventData)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("dataDriftId"u8);
            writer.WriteStringValue(DataDriftId);
            writer.WritePropertyName("dataDriftName"u8);
            writer.WriteStringValue(DataDriftName);
            writer.WritePropertyName("runId"u8);
            writer.WriteStringValue(RunId);
            writer.WritePropertyName("baseDatasetId"u8);
            writer.WriteStringValue(BaseDatasetId);
            writer.WritePropertyName("targetDatasetId"u8);
            writer.WriteStringValue(TargetDatasetId);
            if (Optional.IsDefined(DriftCoefficient))
            {
                writer.WritePropertyName("driftCoefficient"u8);
                writer.WriteNumberValue(DriftCoefficient.Value);
            }
            if (Optional.IsDefined(StartTime))
            {
                if (StartTime != null)
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartTime.Value, "O");
                }
                else
                {
                    writer.WriteNull("startTime");
                }
            }
            if (Optional.IsDefined(EndTime))
            {
                if (EndTime != null)
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndTime.Value, "O");
                }
                else
                {
                    writer.WriteNull("endTime");
                }
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

        MachineLearningServicesDatasetDriftDetectedEventData IJsonModel<MachineLearningServicesDatasetDriftDetectedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicesDatasetDriftDetectedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServicesDatasetDriftDetectedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningServicesDatasetDriftDetectedEventData(document.RootElement, options);
        }

        internal static MachineLearningServicesDatasetDriftDetectedEventData DeserializeMachineLearningServicesDatasetDriftDetectedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string dataDriftId = default;
            string dataDriftName = default;
            string runId = default;
            string baseDatasetId = default;
            string targetDatasetId = default;
            double? driftCoefficient = default;
            DateTimeOffset? startTime = default;
            DateTimeOffset? endTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dataDriftId"u8))
                {
                    dataDriftId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataDriftName"u8))
                {
                    dataDriftName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runId"u8))
                {
                    runId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("baseDatasetId"u8))
                {
                    baseDatasetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetDatasetId"u8))
                {
                    targetDatasetId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("driftCoefficient"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    driftCoefficient = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startTime = null;
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningServicesDatasetDriftDetectedEventData(
                dataDriftId,
                dataDriftName,
                runId,
                baseDatasetId,
                targetDatasetId,
                driftCoefficient,
                startTime,
                endTime,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningServicesDatasetDriftDetectedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicesDatasetDriftDetectedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureMessagingEventGridSystemEventsContext.Default);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServicesDatasetDriftDetectedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningServicesDatasetDriftDetectedEventData IPersistableModel<MachineLearningServicesDatasetDriftDetectedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicesDatasetDriftDetectedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMachineLearningServicesDatasetDriftDetectedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServicesDatasetDriftDetectedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningServicesDatasetDriftDetectedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MachineLearningServicesDatasetDriftDetectedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeMachineLearningServicesDatasetDriftDetectedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }

        internal partial class MachineLearningServicesDatasetDriftDetectedEventDataConverter : JsonConverter<MachineLearningServicesDatasetDriftDetectedEventData>
        {
            public override void Write(Utf8JsonWriter writer, MachineLearningServicesDatasetDriftDetectedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model, ModelSerializationExtensions.WireOptions);
            }

            public override MachineLearningServicesDatasetDriftDetectedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMachineLearningServicesDatasetDriftDetectedEventData(document.RootElement);
            }
        }
    }
}
