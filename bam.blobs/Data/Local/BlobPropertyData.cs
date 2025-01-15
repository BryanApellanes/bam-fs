using Bam.Data.Repositories;

namespace Bam.Blobs.Data.Local;

public class BlobPropertyData :RepoData
{
    public string BlobHash { get; set; }
    public string Name { get; set; }
    public string? Value { get; set; }
}