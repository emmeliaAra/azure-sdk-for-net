// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteCircuitServiceProviderProperties : IUtf8JsonSerializable, IJsonModel<ExpressRouteCircuitServiceProviderProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteCircuitServiceProviderProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExpressRouteCircuitServiceProviderProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitServiceProviderProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteCircuitServiceProviderProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ServiceProviderName))
            {
                writer.WritePropertyName("serviceProviderName"u8);
                writer.WriteStringValue(ServiceProviderName);
            }
            if (Optional.IsDefined(PeeringLocation))
            {
                writer.WritePropertyName("peeringLocation"u8);
                writer.WriteStringValue(PeeringLocation);
            }
            if (Optional.IsDefined(BandwidthInMbps))
            {
                writer.WritePropertyName("bandwidthInMbps"u8);
                writer.WriteNumberValue(BandwidthInMbps.Value);
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

        ExpressRouteCircuitServiceProviderProperties IJsonModel<ExpressRouteCircuitServiceProviderProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitServiceProviderProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteCircuitServiceProviderProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteCircuitServiceProviderProperties(document.RootElement, options);
        }

        internal static ExpressRouteCircuitServiceProviderProperties DeserializeExpressRouteCircuitServiceProviderProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string serviceProviderName = default;
            string peeringLocation = default;
            int? bandwidthInMbps = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceProviderName"u8))
                {
                    serviceProviderName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("peeringLocation"u8))
                {
                    peeringLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bandwidthInMbps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bandwidthInMbps = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExpressRouteCircuitServiceProviderProperties(serviceProviderName, peeringLocation, bandwidthInMbps, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExpressRouteCircuitServiceProviderProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitServiceProviderProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteCircuitServiceProviderProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ExpressRouteCircuitServiceProviderProperties IPersistableModel<ExpressRouteCircuitServiceProviderProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitServiceProviderProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExpressRouteCircuitServiceProviderProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteCircuitServiceProviderProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRouteCircuitServiceProviderProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
