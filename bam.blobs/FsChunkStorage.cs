using Bam.Net.CoreServices.Files;
using Bam.Storage;

namespace Bam.Blobs;

public class FsChunkStorage : IChunkStorage
{
    public FsChunkStorage()
    {
        this.Storage = new FsStorage();
    }

    private FsStorage Storage { get; init; }
    
    public IChunk? GetChunk(string hash)
    {
        return new Chunk()
        {
            ChunkHash = hash,
            Data = Storage.LoadHashHexString(hash).Value
        };
    }

    public void SetChunk(IChunk chunk)
    {
        Storage.Save(chunk.Data);
    }
}