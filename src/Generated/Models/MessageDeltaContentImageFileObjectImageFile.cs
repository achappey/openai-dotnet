// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class MessageDeltaContentImageFileObjectImageFile
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal MessageDeltaContentImageFileObjectImageFile()
        {
        }

        internal MessageDeltaContentImageFileObjectImageFile(string fileId, string detail, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileId = fileId;
            Detail = detail;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        public string FileId { get; }
    }
}
