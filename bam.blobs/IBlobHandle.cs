namespace Bam.Blobs;

public interface IBlobHandle
{
    long ChunkCount { get; }
    int ChunkSize { get; }
    string BlobHash { get; }
    long Length { get; }
    IEnumerable<BlobProperty> GetBlobProperties();
}