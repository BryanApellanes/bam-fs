using Bam.Blobs;

namespace Bam.Blobs;

public class Blob: IBlob
{
    public long ChunkCount { get; }
    public int ChunkLength { get; }
    public string BlobHash { get; }
    public long Length { get; }
    public string Title { get; set; }
}