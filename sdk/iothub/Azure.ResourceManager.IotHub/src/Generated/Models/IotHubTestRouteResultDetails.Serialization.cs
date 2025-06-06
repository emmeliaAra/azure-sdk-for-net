// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    internal partial class IotHubTestRouteResultDetails : IUtf8JsonSerializable, IJsonModel<IotHubTestRouteResultDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubTestRouteResultDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IotHubTestRouteResultDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubTestRouteResultDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubTestRouteResultDetails)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(CompilationErrors))
            {
                writer.WritePropertyName("compilationErrors"u8);
                writer.WriteStartArray();
                foreach (var item in CompilationErrors)
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

        IotHubTestRouteResultDetails IJsonModel<IotHubTestRouteResultDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubTestRouteResultDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubTestRouteResultDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubTestRouteResultDetails(document.RootElement, options);
        }

        internal static IotHubTestRouteResultDetails DeserializeIotHubTestRouteResultDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<RouteCompilationError> compilationErrors = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("compilationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RouteCompilationError> array = new List<RouteCompilationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RouteCompilationError.DeserializeRouteCompilationError(item, options));
                    }
                    compilationErrors = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IotHubTestRouteResultDetails(compilationErrors ?? new ChangeTrackingList<RouteCompilationError>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubTestRouteResultDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubTestRouteResultDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerIotHubContext.Default);
                default:
                    throw new FormatException($"The model {nameof(IotHubTestRouteResultDetails)} does not support writing '{options.Format}' format.");
            }
        }

        IotHubTestRouteResultDetails IPersistableModel<IotHubTestRouteResultDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubTestRouteResultDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeIotHubTestRouteResultDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubTestRouteResultDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubTestRouteResultDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
