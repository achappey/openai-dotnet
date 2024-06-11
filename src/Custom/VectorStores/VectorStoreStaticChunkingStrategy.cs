namespace OpenAI.VectorStores;

/// <summary>
/// A representation of a file association between an uploaded file and a vector store.
/// </summary>
[CodeGenModel("VectorStoreStaticChunkingStrategy")]
public partial class VectorStoreStaticChunkingStrategy
{
    [CodeGenMember("MaxChunkSizeTokens")]
    public int MaxChunkSizeTokens { get; set; }

    [CodeGenMember("ChunkOverlapTokens")]
    public int ChunkOverlapTokens { get; set; }
}