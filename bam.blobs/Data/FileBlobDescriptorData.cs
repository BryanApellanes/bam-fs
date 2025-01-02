using Bam.Files;

namespace Bam.Files.Data;

public class FileBlobDescriptorData : BlobDescriptorData
{
    public string FileName
    {
        get => Title;
        set => Title = value;
    }
    
    public string? Directory { get; set; }
}