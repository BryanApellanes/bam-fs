namespace Bam.Blobs
{
    public interface IFileBlobHandle : IBlobHandle
    {
        string? FileName { get; }
        string? Directory { get; }
    }
}