// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text
{
    public partial class CharacterMaskPolicyType : IUtf8JsonSerializable, IJsonModel<CharacterMaskPolicyType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CharacterMaskPolicyType>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CharacterMaskPolicyType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CharacterMaskPolicyType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CharacterMaskPolicyType)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(RedactionCharacter))
            {
                writer.WritePropertyName("redactionCharacter"u8);
                writer.WriteStringValue(RedactionCharacter.Value.ToString());
            }
        }

        CharacterMaskPolicyType IJsonModel<CharacterMaskPolicyType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CharacterMaskPolicyType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CharacterMaskPolicyType)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCharacterMaskPolicyType(document.RootElement, options);
        }

        internal static CharacterMaskPolicyType DeserializeCharacterMaskPolicyType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RedactionCharacter? redactionCharacter = default;
            RedactionPolicyKind policyKind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("redactionCharacter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    redactionCharacter = new RedactionCharacter(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyKind"u8))
                {
                    policyKind = new RedactionPolicyKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CharacterMaskPolicyType(policyKind, serializedAdditionalRawData, redactionCharacter);
        }

        BinaryData IPersistableModel<CharacterMaskPolicyType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CharacterMaskPolicyType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAILanguageTextContext.Default);
                default:
                    throw new FormatException($"The model {nameof(CharacterMaskPolicyType)} does not support writing '{options.Format}' format.");
            }
        }

        CharacterMaskPolicyType IPersistableModel<CharacterMaskPolicyType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CharacterMaskPolicyType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeCharacterMaskPolicyType(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CharacterMaskPolicyType)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CharacterMaskPolicyType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new CharacterMaskPolicyType FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeCharacterMaskPolicyType(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
