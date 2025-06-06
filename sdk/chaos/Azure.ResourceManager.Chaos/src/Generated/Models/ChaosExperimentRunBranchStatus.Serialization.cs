// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class ChaosExperimentRunBranchStatus : IUtf8JsonSerializable, IJsonModel<ChaosExperimentRunBranchStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChaosExperimentRunBranchStatus>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ChaosExperimentRunBranchStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosExperimentRunBranchStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosExperimentRunBranchStatus)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(BranchName))
            {
                writer.WritePropertyName("branchName"u8);
                writer.WriteStringValue(BranchName);
            }
            if (options.Format != "W" && Optional.IsDefined(BranchId))
            {
                writer.WritePropertyName("branchId"u8);
                writer.WriteStringValue(BranchId);
            }
            if (options.Format != "W" && Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Actions))
            {
                writer.WritePropertyName("actions"u8);
                writer.WriteStartArray();
                foreach (var item in Actions)
                {
                    writer.WriteObjectValue(item, options);
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

        ChaosExperimentRunBranchStatus IJsonModel<ChaosExperimentRunBranchStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosExperimentRunBranchStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosExperimentRunBranchStatus)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChaosExperimentRunBranchStatus(document.RootElement, options);
        }

        internal static ChaosExperimentRunBranchStatus DeserializeChaosExperimentRunBranchStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string branchName = default;
            string branchId = default;
            string status = default;
            IReadOnlyList<ChaosExperimentRunActionStatus> actions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("branchName"u8))
                {
                    branchName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("branchId"u8))
                {
                    branchId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ChaosExperimentRunActionStatus> array = new List<ChaosExperimentRunActionStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChaosExperimentRunActionStatus.DeserializeChaosExperimentRunActionStatus(item, options));
                    }
                    actions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ChaosExperimentRunBranchStatus(branchName, branchId, status, actions ?? new ChangeTrackingList<ChaosExperimentRunActionStatus>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChaosExperimentRunBranchStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosExperimentRunBranchStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerChaosContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ChaosExperimentRunBranchStatus)} does not support writing '{options.Format}' format.");
            }
        }

        ChaosExperimentRunBranchStatus IPersistableModel<ChaosExperimentRunBranchStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosExperimentRunBranchStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeChaosExperimentRunBranchStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChaosExperimentRunBranchStatus)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChaosExperimentRunBranchStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
