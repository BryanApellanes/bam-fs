namespace Bam.Blobs;

public interface IBlob
{
    long ChunkCount { get; }
    int ChunkLength { get; }
    string BlobHash { get; }
    long Length { get; }
    string Title { get; set; }
}