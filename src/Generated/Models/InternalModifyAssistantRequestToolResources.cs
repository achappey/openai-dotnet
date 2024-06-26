// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalModifyAssistantRequestToolResources
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        public InternalModifyAssistantRequestToolResources()
        {
        }

        internal InternalModifyAssistantRequestToolResources(InternalModifyAssistantRequestToolResourcesCodeInterpreter codeInterpreter, InternalModifyAssistantRequestToolResourcesFileSearch fileSearch, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CodeInterpreter = codeInterpreter;
            FileSearch = fileSearch;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        public InternalModifyAssistantRequestToolResourcesCodeInterpreter CodeInterpreter { get; set; }
        public InternalModifyAssistantRequestToolResourcesFileSearch FileSearch { get; set; }
    }
}
