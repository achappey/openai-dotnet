namespace OpenAI.VectorStores;

/// <summary>
/// A representation of a file association between an uploaded file and a vector store.
/// </summary>
[CodeGenModel("VectorStoreFileAssociationOptions")]
public partial class VectorStoreFileAssociationOptions
{
    [CodeGenMember("ChunkingStrategy")]
    public VectorStoreChunkingStrategy? ChunkingStrategy { get; set; }

}