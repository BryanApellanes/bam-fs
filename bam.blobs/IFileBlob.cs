namespace Bam.Blobs
{
    public interface IFileBlob : IBlob
    {
        string? Directory { get; }
    }
}