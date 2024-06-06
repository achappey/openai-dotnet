// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.FineTuning
{
    internal partial class InternalFineTuningIntegrationWandb
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        internal InternalFineTuningIntegrationWandb(string project)
        {
            Argument.AssertNotNull(project, nameof(project));

            Project = project;
            Tags = new ChangeTrackingList<string>();
        }

        internal InternalFineTuningIntegrationWandb(string project, string name, string entity, IReadOnlyList<string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Project = project;
            Name = name;
            Entity = entity;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalFineTuningIntegrationWandb()
        {
        }

        public string Project { get; }
        public string Name { get; }
        public string Entity { get; }
        public IReadOnlyList<string> Tags { get; }
    }
}