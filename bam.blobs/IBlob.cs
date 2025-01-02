namespace Bam.Files;

public interface IBlob
{
    long ChunkCount { get; }
    int ChunkLength { get; }
    string Hash { get; }
    long Length { get; }
    string Title { get; set; }
}