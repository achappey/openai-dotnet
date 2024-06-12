namespace OpenAI.VectorStores;

/// <summary>
/// A representation of a file association between an uploaded file and a vector store.
/// </summary>
[CodeGenModel("VectorStoreChunkingStrategy")]
public partial class VectorStoreChunkingStrategy
{
    [CodeGenMember("Type")]
    public string Type { get; set; }

    [CodeGenMember("StaticChunkingStrategy")]
    public VectorStoreStaticChunkingStrategy Static { get; set; }
}