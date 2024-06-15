// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Assistants
{
    internal partial class InternalResponseMessageTextContent : IJsonModel<InternalResponseMessageTextContent>
    {
        InternalResponseMessageTextContent IJsonModel<InternalResponseMessageTextContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalResponseMessageTextContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalResponseMessageTextContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalResponseMessageTextContent(document.RootElement, options);
        }

        internal static InternalResponseMessageTextContent DeserializeInternalResponseMessageTextContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            MessageContentTextObjectText text = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = MessageContentTextObjectText.DeserializeMessageContentTextObjectText(property.Value, options);
                    continue;
                }
                if (true)
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new InternalResponseMessageTextContent(serializedAdditionalRawData, type, text);
        }

        BinaryData IPersistableModel<InternalResponseMessageTextContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalResponseMessageTextContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalResponseMessageTextContent)} does not support writing '{options.Format}' format.");
            }
        }

        InternalResponseMessageTextContent IPersistableModel<InternalResponseMessageTextContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalResponseMessageTextContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalResponseMessageTextContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalResponseMessageTextContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalResponseMessageTextContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static new InternalResponseMessageTextContent FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalResponseMessageTextContent(document.RootElement);
        }

        internal override BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
