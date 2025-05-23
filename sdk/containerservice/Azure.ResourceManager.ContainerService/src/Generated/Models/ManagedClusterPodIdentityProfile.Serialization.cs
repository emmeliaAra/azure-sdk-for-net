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
    public partial class ManagedClusterPodIdentityProfile : IUtf8JsonSerializable, IJsonModel<ManagedClusterPodIdentityProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterPodIdentityProfile>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ManagedClusterPodIdentityProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterPodIdentityProfile)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(AllowNetworkPluginKubenet))
            {
                writer.WritePropertyName("allowNetworkPluginKubenet"u8);
                writer.WriteBooleanValue(AllowNetworkPluginKubenet.Value);
            }
            if (Optional.IsCollectionDefined(UserAssignedIdentities))
            {
                writer.WritePropertyName("userAssignedIdentities"u8);
                writer.WriteStartArray();
                foreach (var item in UserAssignedIdentities)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserAssignedIdentityExceptions))
            {
                writer.WritePropertyName("userAssignedIdentityExceptions"u8);
                writer.WriteStartArray();
                foreach (var item in UserAssignedIdentityExceptions)
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

        ManagedClusterPodIdentityProfile IJsonModel<ManagedClusterPodIdentityProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentityProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterPodIdentityProfile)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterPodIdentityProfile(document.RootElement, options);
        }

        internal static ManagedClusterPodIdentityProfile DeserializeManagedClusterPodIdentityProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? enabled = default;
            bool? allowNetworkPluginKubenet = default;
            IList<ManagedClusterPodIdentity> userAssignedIdentities = default;
            IList<ManagedClusterPodIdentityException> userAssignedIdentityExceptions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowNetworkPluginKubenet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allowNetworkPluginKubenet = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("userAssignedIdentities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedClusterPodIdentity> array = new List<ManagedClusterPodIdentity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedClusterPodIdentity.DeserializeManagedClusterPodIdentity(item, options));
                    }
                    userAssignedIdentities = array;
                    continue;
                }
                if (property.NameEquals("userAssignedIdentityExceptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedClusterPodIdentityException> array = new List<ManagedClusterPodIdentityException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedClusterPodIdentityException.DeserializeManagedClusterPodIdentityException(item, options));
                    }
                    userAssignedIdentityExceptions = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ManagedClusterPodIdentityProfile(enabled, allowNetworkPluginKubenet, userAssignedIdentities ?? new ChangeTrackingList<ManagedClusterPodIdentity>(), userAssignedIdentityExceptions ?? new ChangeTrackingList<ManagedClusterPodIdentityException>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsEnabled), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  enabled: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsEnabled))
                {
                    builder.Append("  enabled: ");
                    var boolValue = IsEnabled.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AllowNetworkPluginKubenet), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  allowNetworkPluginKubenet: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AllowNetworkPluginKubenet))
                {
                    builder.Append("  allowNetworkPluginKubenet: ");
                    var boolValue = AllowNetworkPluginKubenet.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UserAssignedIdentities), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  userAssignedIdentities: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(UserAssignedIdentities))
                {
                    if (UserAssignedIdentities.Any())
                    {
                        builder.Append("  userAssignedIdentities: ");
                        builder.AppendLine("[");
                        foreach (var item in UserAssignedIdentities)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  userAssignedIdentities: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UserAssignedIdentityExceptions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  userAssignedIdentityExceptions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(UserAssignedIdentityExceptions))
                {
                    if (UserAssignedIdentityExceptions.Any())
                    {
                        builder.Append("  userAssignedIdentityExceptions: ");
                        builder.AppendLine("[");
                        foreach (var item in UserAssignedIdentityExceptions)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  userAssignedIdentityExceptions: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ManagedClusterPodIdentityProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerContainerServiceContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterPodIdentityProfile)} does not support writing '{options.Format}' format.");
            }
        }

        ManagedClusterPodIdentityProfile IPersistableModel<ManagedClusterPodIdentityProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentityProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeManagedClusterPodIdentityProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterPodIdentityProfile)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterPodIdentityProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
