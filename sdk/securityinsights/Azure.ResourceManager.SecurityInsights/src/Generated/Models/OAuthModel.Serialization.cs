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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class OAuthModel : IUtf8JsonSerializable, IJsonModel<OAuthModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OAuthModel>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OAuthModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OAuthModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OAuthModel)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(AuthorizationCode))
            {
                writer.WritePropertyName("authorizationCode"u8);
                writer.WriteStringValue(AuthorizationCode);
            }
            writer.WritePropertyName("clientSecret"u8);
            writer.WriteStringValue(ClientSecret);
            writer.WritePropertyName("clientId"u8);
            writer.WriteStringValue(ClientId);
            if (Optional.IsDefined(IsCredentialsInHeaders))
            {
                if (IsCredentialsInHeaders != null)
                {
                    writer.WritePropertyName("isCredentialsInHeaders"u8);
                    writer.WriteBooleanValue(IsCredentialsInHeaders.Value);
                }
                else
                {
                    writer.WriteNull("isCredentialsInHeaders");
                }
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(RedirectUri))
            {
                writer.WritePropertyName("redirectUri"u8);
                writer.WriteStringValue(RedirectUri.AbsoluteUri);
            }
            writer.WritePropertyName("grantType"u8);
            writer.WriteStringValue(GrantType);
            writer.WritePropertyName("tokenEndpoint"u8);
            writer.WriteStringValue(TokenEndpoint);
            if (Optional.IsCollectionDefined(TokenEndpointHeaders))
            {
                writer.WritePropertyName("tokenEndpointHeaders"u8);
                writer.WriteStartObject();
                foreach (var item in TokenEndpointHeaders)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(TokenEndpointQueryParameters))
            {
                writer.WritePropertyName("tokenEndpointQueryParameters"u8);
                writer.WriteStartObject();
                foreach (var item in TokenEndpointQueryParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(AuthorizationEndpoint))
            {
                writer.WritePropertyName("authorizationEndpoint"u8);
                writer.WriteStringValue(AuthorizationEndpoint);
            }
            if (Optional.IsCollectionDefined(AuthorizationEndpointHeaders))
            {
                writer.WritePropertyName("authorizationEndpointHeaders"u8);
                writer.WriteStartObject();
                foreach (var item in AuthorizationEndpointHeaders)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(AuthorizationEndpointQueryParameters))
            {
                writer.WritePropertyName("authorizationEndpointQueryParameters"u8);
                writer.WriteStartObject();
                foreach (var item in AuthorizationEndpointQueryParameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(IsJwtBearerFlow))
            {
                writer.WritePropertyName("isJwtBearerFlow"u8);
                writer.WriteBooleanValue(IsJwtBearerFlow.Value);
            }
            if (Optional.IsDefined(AccessTokenPrepend))
            {
                writer.WritePropertyName("accessTokenPrepend"u8);
                writer.WriteStringValue(AccessTokenPrepend);
            }
        }

        OAuthModel IJsonModel<OAuthModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OAuthModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OAuthModel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOAuthModel(document.RootElement, options);
        }

        internal static OAuthModel DeserializeOAuthModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string authorizationCode = default;
            string clientSecret = default;
            string clientId = default;
            bool? isCredentialsInHeaders = default;
            string scope = default;
            Uri redirectUri = default;
            string grantType = default;
            string tokenEndpoint = default;
            IDictionary<string, string> tokenEndpointHeaders = default;
            IDictionary<string, string> tokenEndpointQueryParameters = default;
            string authorizationEndpoint = default;
            IDictionary<string, string> authorizationEndpointHeaders = default;
            IDictionary<string, string> authorizationEndpointQueryParameters = default;
            bool? isJwtBearerFlow = default;
            string accessTokenPrepend = default;
            CcpAuthType type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authorizationCode"u8))
                {
                    authorizationCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientSecret"u8))
                {
                    clientSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    clientId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isCredentialsInHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        isCredentialsInHeaders = null;
                        continue;
                    }
                    isCredentialsInHeaders = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("redirectUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redirectUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("grantType"u8))
                {
                    grantType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tokenEndpoint"u8))
                {
                    tokenEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tokenEndpointHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tokenEndpointHeaders = dictionary;
                    continue;
                }
                if (property.NameEquals("tokenEndpointQueryParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tokenEndpointQueryParameters = dictionary;
                    continue;
                }
                if (property.NameEquals("authorizationEndpoint"u8))
                {
                    authorizationEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorizationEndpointHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    authorizationEndpointHeaders = dictionary;
                    continue;
                }
                if (property.NameEquals("authorizationEndpointQueryParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    authorizationEndpointQueryParameters = dictionary;
                    continue;
                }
                if (property.NameEquals("isJwtBearerFlow"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isJwtBearerFlow = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("accessTokenPrepend"u8))
                {
                    accessTokenPrepend = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new CcpAuthType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OAuthModel(
                type,
                serializedAdditionalRawData,
                authorizationCode,
                clientSecret,
                clientId,
                isCredentialsInHeaders,
                scope,
                redirectUri,
                grantType,
                tokenEndpoint,
                tokenEndpointHeaders ?? new ChangeTrackingDictionary<string, string>(),
                tokenEndpointQueryParameters ?? new ChangeTrackingDictionary<string, string>(),
                authorizationEndpoint,
                authorizationEndpointHeaders ?? new ChangeTrackingDictionary<string, string>(),
                authorizationEndpointQueryParameters ?? new ChangeTrackingDictionary<string, string>(),
                isJwtBearerFlow,
                accessTokenPrepend);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthorizationCode), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  authorizationCode: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AuthorizationCode))
                {
                    builder.Append("  authorizationCode: ");
                    if (AuthorizationCode.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AuthorizationCode}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AuthorizationCode}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientSecret), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientSecret: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientSecret))
                {
                    builder.Append("  clientSecret: ");
                    if (ClientSecret.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientSecret}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientSecret}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientId), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  clientId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientId))
                {
                    builder.Append("  clientId: ");
                    if (ClientId.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ClientId}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ClientId}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsCredentialsInHeaders), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isCredentialsInHeaders: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsCredentialsInHeaders))
                {
                    builder.Append("  isCredentialsInHeaders: ");
                    var boolValue = IsCredentialsInHeaders.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Scope), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scope: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Scope))
                {
                    builder.Append("  scope: ");
                    if (Scope.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Scope}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Scope}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RedirectUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  redirectUri: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RedirectUri))
                {
                    builder.Append("  redirectUri: ");
                    builder.AppendLine($"'{RedirectUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(GrantType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  grantType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(GrantType))
                {
                    builder.Append("  grantType: ");
                    if (GrantType.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{GrantType}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{GrantType}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TokenEndpoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tokenEndpoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TokenEndpoint))
                {
                    builder.Append("  tokenEndpoint: ");
                    if (TokenEndpoint.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{TokenEndpoint}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{TokenEndpoint}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TokenEndpointHeaders), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tokenEndpointHeaders: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(TokenEndpointHeaders))
                {
                    if (TokenEndpointHeaders.Any())
                    {
                        builder.Append("  tokenEndpointHeaders: ");
                        builder.AppendLine("{");
                        foreach (var item in TokenEndpointHeaders)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TokenEndpointQueryParameters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  tokenEndpointQueryParameters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(TokenEndpointQueryParameters))
                {
                    if (TokenEndpointQueryParameters.Any())
                    {
                        builder.Append("  tokenEndpointQueryParameters: ");
                        builder.AppendLine("{");
                        foreach (var item in TokenEndpointQueryParameters)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthorizationEndpoint), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  authorizationEndpoint: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AuthorizationEndpoint))
                {
                    builder.Append("  authorizationEndpoint: ");
                    if (AuthorizationEndpoint.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AuthorizationEndpoint}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AuthorizationEndpoint}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthorizationEndpointHeaders), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  authorizationEndpointHeaders: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AuthorizationEndpointHeaders))
                {
                    if (AuthorizationEndpointHeaders.Any())
                    {
                        builder.Append("  authorizationEndpointHeaders: ");
                        builder.AppendLine("{");
                        foreach (var item in AuthorizationEndpointHeaders)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthorizationEndpointQueryParameters), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  authorizationEndpointQueryParameters: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AuthorizationEndpointQueryParameters))
                {
                    if (AuthorizationEndpointQueryParameters.Any())
                    {
                        builder.Append("  authorizationEndpointQueryParameters: ");
                        builder.AppendLine("{");
                        foreach (var item in AuthorizationEndpointQueryParameters)
                        {
                            builder.Append($"    '{item.Key}': ");
                            if (item.Value == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Value.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("'''");
                                builder.AppendLine($"{item.Value}'''");
                            }
                            else
                            {
                                builder.AppendLine($"'{item.Value}'");
                            }
                        }
                        builder.AppendLine("  }");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsJwtBearerFlow), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  isJwtBearerFlow: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsJwtBearerFlow))
                {
                    builder.Append("  isJwtBearerFlow: ");
                    var boolValue = IsJwtBearerFlow.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccessTokenPrepend), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  accessTokenPrepend: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AccessTokenPrepend))
                {
                    builder.Append("  accessTokenPrepend: ");
                    if (AccessTokenPrepend.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AccessTokenPrepend}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AccessTokenPrepend}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AuthType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  type: ");
                builder.AppendLine($"'{AuthType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<OAuthModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OAuthModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerSecurityInsightsContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(OAuthModel)} does not support writing '{options.Format}' format.");
            }
        }

        OAuthModel IPersistableModel<OAuthModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OAuthModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeOAuthModel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OAuthModel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OAuthModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
