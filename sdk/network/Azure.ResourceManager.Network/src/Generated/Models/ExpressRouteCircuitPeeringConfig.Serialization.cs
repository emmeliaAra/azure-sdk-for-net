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
    public partial class ExpressRouteCircuitPeeringConfig : IUtf8JsonSerializable, IJsonModel<ExpressRouteCircuitPeeringConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ExpressRouteCircuitPeeringConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ExpressRouteCircuitPeeringConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitPeeringConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteCircuitPeeringConfig)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(AdvertisedPublicPrefixes))
            {
                writer.WritePropertyName("advertisedPublicPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AdvertisedPublicPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AdvertisedCommunities))
            {
                writer.WritePropertyName("advertisedCommunities"u8);
                writer.WriteStartArray();
                foreach (var item in AdvertisedCommunities)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(AdvertisedPublicPrefixesState))
            {
                writer.WritePropertyName("advertisedPublicPrefixesState"u8);
                writer.WriteStringValue(AdvertisedPublicPrefixesState.Value.ToString());
            }
            if (Optional.IsDefined(LegacyMode))
            {
                writer.WritePropertyName("legacyMode"u8);
                writer.WriteNumberValue(LegacyMode.Value);
            }
            if (Optional.IsDefined(CustomerASN))
            {
                writer.WritePropertyName("customerASN"u8);
                writer.WriteNumberValue(CustomerASN.Value);
            }
            if (Optional.IsDefined(RoutingRegistryName))
            {
                writer.WritePropertyName("routingRegistryName"u8);
                writer.WriteStringValue(RoutingRegistryName);
            }
            if (Optional.IsCollectionDefined(AdvertisedPublicPrefixInfo))
            {
                writer.WritePropertyName("advertisedPublicPrefixInfo"u8);
                writer.WriteStartArray();
                foreach (var item in AdvertisedPublicPrefixInfo)
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

        ExpressRouteCircuitPeeringConfig IJsonModel<ExpressRouteCircuitPeeringConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitPeeringConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ExpressRouteCircuitPeeringConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeExpressRouteCircuitPeeringConfig(document.RootElement, options);
        }

        internal static ExpressRouteCircuitPeeringConfig DeserializeExpressRouteCircuitPeeringConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> advertisedPublicPrefixes = default;
            IList<string> advertisedCommunities = default;
            ExpressRouteCircuitPeeringAdvertisedPublicPrefixState? advertisedPublicPrefixesState = default;
            int? legacyMode = default;
            int? customerASN = default;
            string routingRegistryName = default;
            IList<AdvertisedPublicPrefixProperties> advertisedPublicPrefixInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("advertisedPublicPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    advertisedPublicPrefixes = array;
                    continue;
                }
                if (property.NameEquals("advertisedCommunities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    advertisedCommunities = array;
                    continue;
                }
                if (property.NameEquals("advertisedPublicPrefixesState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    advertisedPublicPrefixesState = new ExpressRouteCircuitPeeringAdvertisedPublicPrefixState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("legacyMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    legacyMode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("customerASN"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customerASN = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("routingRegistryName"u8))
                {
                    routingRegistryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("advertisedPublicPrefixInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AdvertisedPublicPrefixProperties> array = new List<AdvertisedPublicPrefixProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AdvertisedPublicPrefixProperties.DeserializeAdvertisedPublicPrefixProperties(item, options));
                    }
                    advertisedPublicPrefixInfo = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ExpressRouteCircuitPeeringConfig(
                advertisedPublicPrefixes ?? new ChangeTrackingList<string>(),
                advertisedCommunities ?? new ChangeTrackingList<string>(),
                advertisedPublicPrefixesState,
                legacyMode,
                customerASN,
                routingRegistryName,
                advertisedPublicPrefixInfo ?? new ChangeTrackingList<AdvertisedPublicPrefixProperties>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ExpressRouteCircuitPeeringConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitPeeringConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerNetworkContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteCircuitPeeringConfig)} does not support writing '{options.Format}' format.");
            }
        }

        ExpressRouteCircuitPeeringConfig IPersistableModel<ExpressRouteCircuitPeeringConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ExpressRouteCircuitPeeringConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeExpressRouteCircuitPeeringConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ExpressRouteCircuitPeeringConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ExpressRouteCircuitPeeringConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
