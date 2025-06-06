// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    internal partial class RoleDefinitionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RoleName))
            {
                writer.WritePropertyName("roleName"u8);
                writer.WriteStringValue(RoleName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(RoleType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RoleType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Permissions))
            {
                writer.WritePropertyName("permissions"u8);
                writer.WriteStartArray();
                foreach (var item in Permissions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AssignableScopes))
            {
                writer.WritePropertyName("assignableScopes"u8);
                writer.WriteStartArray();
                foreach (var item in AssignableScopes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static RoleDefinitionProperties DeserializeRoleDefinitionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string roleName = default;
            string description = default;
            KeyVaultRoleType? type = default;
            IList<KeyVaultPermission> permissions = default;
            IList<KeyVaultRoleScope> assignableScopes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("roleName"u8))
                {
                    roleName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new KeyVaultRoleType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("permissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KeyVaultPermission> array = new List<KeyVaultPermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KeyVaultPermission.DeserializeKeyVaultPermission(item));
                    }
                    permissions = array;
                    continue;
                }
                if (property.NameEquals("assignableScopes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KeyVaultRoleScope> array = new List<KeyVaultRoleScope>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new KeyVaultRoleScope(item.GetString()));
                    }
                    assignableScopes = array;
                    continue;
                }
            }
            return new RoleDefinitionProperties(roleName, description, type, permissions ?? new ChangeTrackingList<KeyVaultPermission>(), assignableScopes ?? new ChangeTrackingList<KeyVaultRoleScope>());
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RoleDefinitionProperties FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeRoleDefinitionProperties(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
