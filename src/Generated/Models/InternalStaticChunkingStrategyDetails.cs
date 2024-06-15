// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.VectorStores
{
    internal partial class InternalStaticChunkingStrategyDetails
    {
        internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        public InternalStaticChunkingStrategyDetails(int maxChunkSizeTokens, int chunkOverlapTokens)
        {
            MaxChunkSizeTokens = maxChunkSizeTokens;
            ChunkOverlapTokens = chunkOverlapTokens;
        }

        internal InternalStaticChunkingStrategyDetails(int maxChunkSizeTokens, int chunkOverlapTokens, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MaxChunkSizeTokens = maxChunkSizeTokens;
            ChunkOverlapTokens = chunkOverlapTokens;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalStaticChunkingStrategyDetails()
        {
        }

        public int MaxChunkSizeTokens { get; set; }
        public int ChunkOverlapTokens { get; set; }
    }
}
