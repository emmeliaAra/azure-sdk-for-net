// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text.Authoring
{
    public partial class DocumentMultiLabelClassificationEvalResult : IUtf8JsonSerializable, IJsonModel<DocumentMultiLabelClassificationEvalResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DocumentMultiLabelClassificationEvalResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DocumentMultiLabelClassificationEvalResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentMultiLabelClassificationEvalResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentMultiLabelClassificationEvalResult)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("expectedClasses"u8);
            writer.WriteStartArray();
            foreach (var item in ExpectedClasses)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("predictedClasses"u8);
            writer.WriteStartArray();
            foreach (var item in PredictedClasses)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
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

        DocumentMultiLabelClassificationEvalResult IJsonModel<DocumentMultiLabelClassificationEvalResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentMultiLabelClassificationEvalResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DocumentMultiLabelClassificationEvalResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDocumentMultiLabelClassificationEvalResult(document.RootElement, options);
        }

        internal static DocumentMultiLabelClassificationEvalResult DeserializeDocumentMultiLabelClassificationEvalResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> expectedClasses = default;
            IReadOnlyList<string> predictedClasses = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expectedClasses"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    expectedClasses = array;
                    continue;
                }
                if (property.NameEquals("predictedClasses"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    predictedClasses = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DocumentMultiLabelClassificationEvalResult(expectedClasses, predictedClasses, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DocumentMultiLabelClassificationEvalResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentMultiLabelClassificationEvalResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAILanguageTextAuthoringContext.Default);
                default:
                    throw new FormatException($"The model {nameof(DocumentMultiLabelClassificationEvalResult)} does not support writing '{options.Format}' format.");
            }
        }

        DocumentMultiLabelClassificationEvalResult IPersistableModel<DocumentMultiLabelClassificationEvalResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DocumentMultiLabelClassificationEvalResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDocumentMultiLabelClassificationEvalResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DocumentMultiLabelClassificationEvalResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DocumentMultiLabelClassificationEvalResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static DocumentMultiLabelClassificationEvalResult FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeDocumentMultiLabelClassificationEvalResult(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
