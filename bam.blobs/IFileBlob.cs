namespace Bam.Files
{
    public interface IFileBlob : IBlob
    {
        string? Directory { get; }
    }
}