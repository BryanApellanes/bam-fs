namespace Bam.Chunking
{
    public interface IChunkedFileDescriptor
    {
        long ChunkCount { get; }
        int ChunkLength { get; }
        string FileHash { get; }
        long FileLength { get; }
        string? OriginalFileName { get; set; }
        string? OriginalDirectory { get; }
    }
}