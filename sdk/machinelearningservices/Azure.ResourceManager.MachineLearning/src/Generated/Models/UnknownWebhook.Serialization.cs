// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    internal partial class UnknownWebhook : IUtf8JsonSerializable, IJsonModel<MachineLearningWebhook>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningWebhook>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningWebhook>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWebhook>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWebhook)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        MachineLearningWebhook IJsonModel<MachineLearningWebhook>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWebhook>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningWebhook)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningWebhook(document.RootElement, options);
        }

        internal static UnknownWebhook DeserializeUnknownWebhook(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MachineLearningWebhookType webhookType = "Unknown";
            string eventType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("webhookType"u8))
                {
                    webhookType = new MachineLearningWebhookType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("eventType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        eventType = null;
                        continue;
                    }
                    eventType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownWebhook(webhookType, eventType, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(WebhookType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  webhookType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  webhookType: ");
                builder.AppendLine($"'{WebhookType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EventType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  eventType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EventType))
                {
                    builder.Append("  eventType: ");
                    if (EventType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{EventType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{EventType}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<MachineLearningWebhook>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWebhook>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMachineLearningContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWebhook)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningWebhook IPersistableModel<MachineLearningWebhook>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningWebhook>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeMachineLearningWebhook(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningWebhook)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningWebhook>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
