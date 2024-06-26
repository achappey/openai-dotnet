// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public partial class ToolOutput
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        public ToolOutput()
        {
        }

        internal ToolOutput(string toolCallId, string output, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ToolCallId = toolCallId;
            Output = output;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        public string ToolCallId { get; set; }
        public string Output { get; set; }
    }
}
