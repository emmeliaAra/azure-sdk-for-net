// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    internal partial class KubernetesVersionCapabilities : IUtf8JsonSerializable, IJsonModel<KubernetesVersionCapabilities>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesVersionCapabilities>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<KubernetesVersionCapabilities>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesVersionCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesVersionCapabilities)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(SupportPlan))
            {
                writer.WritePropertyName("supportPlan"u8);
                writer.WriteStartArray();
                foreach (var item in SupportPlan)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
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

        KubernetesVersionCapabilities IJsonModel<KubernetesVersionCapabilities>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesVersionCapabilities>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesVersionCapabilities)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesVersionCapabilities(document.RootElement, options);
        }

        internal static KubernetesVersionCapabilities DeserializeKubernetesVersionCapabilities(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<KubernetesSupportPlan> supportPlan = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportPlan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KubernetesSupportPlan> array = new List<KubernetesSupportPlan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new KubernetesSupportPlan(item.GetString()));
                    }
                    supportPlan = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new KubernetesVersionCapabilities(supportPlan ?? new ChangeTrackingList<KubernetesSupportPlan>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SupportPlan), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  supportPlan: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(SupportPlan))
                {
                    if (SupportPlan.Any())
                    {
                        builder.Append("  supportPlan: ");
                        builder.AppendLine("[");
                        foreach (var item in SupportPlan)
                        {
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<KubernetesVersionCapabilities>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesVersionCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerContainerServiceContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesVersionCapabilities)} does not support writing '{options.Format}' format.");
            }
        }

        KubernetesVersionCapabilities IPersistableModel<KubernetesVersionCapabilities>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesVersionCapabilities>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeKubernetesVersionCapabilities(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesVersionCapabilities)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesVersionCapabilities>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
