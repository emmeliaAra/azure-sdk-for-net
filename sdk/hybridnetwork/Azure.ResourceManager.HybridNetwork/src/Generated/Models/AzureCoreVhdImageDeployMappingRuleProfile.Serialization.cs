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
    public partial class AzureCoreVhdImageDeployMappingRuleProfile : IUtf8JsonSerializable, IJsonModel<AzureCoreVhdImageDeployMappingRuleProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureCoreVhdImageDeployMappingRuleProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AzureCoreVhdImageDeployMappingRuleProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreVhdImageDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureCoreVhdImageDeployMappingRuleProfile)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(VhdImageMappingRuleProfile))
            {
                writer.WritePropertyName("vhdImageMappingRuleProfile"u8);
                writer.WriteObjectValue(VhdImageMappingRuleProfile, options);
            }
        }

        AzureCoreVhdImageDeployMappingRuleProfile IJsonModel<AzureCoreVhdImageDeployMappingRuleProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreVhdImageDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureCoreVhdImageDeployMappingRuleProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureCoreVhdImageDeployMappingRuleProfile(document.RootElement, options);
        }

        internal static AzureCoreVhdImageDeployMappingRuleProfile DeserializeAzureCoreVhdImageDeployMappingRuleProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            VhdImageMappingRuleProfile vhdImageMappingRuleProfile = default;
            ApplicationEnablement? applicationEnablement = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vhdImageMappingRuleProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vhdImageMappingRuleProfile = VhdImageMappingRuleProfile.DeserializeVhdImageMappingRuleProfile(property.Value, options);
                    continue;
                }
                if (property.NameEquals("applicationEnablement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationEnablement = new ApplicationEnablement(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureCoreVhdImageDeployMappingRuleProfile(applicationEnablement, serializedAdditionalRawData, vhdImageMappingRuleProfile);
        }

        BinaryData IPersistableModel<AzureCoreVhdImageDeployMappingRuleProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreVhdImageDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHybridNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AzureCoreVhdImageDeployMappingRuleProfile)} does not support writing '{options.Format}' format.");
            }
        }

        AzureCoreVhdImageDeployMappingRuleProfile IPersistableModel<AzureCoreVhdImageDeployMappingRuleProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreVhdImageDeployMappingRuleProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAzureCoreVhdImageDeployMappingRuleProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureCoreVhdImageDeployMappingRuleProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureCoreVhdImageDeployMappingRuleProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
