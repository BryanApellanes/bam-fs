using Bam.Data.Repositories;

namespace Bam.Blobs.Data.Distributed;

public class OpaqueBlobPropertyData : RepoData
{
    public string BlobHashHmac { get; set; }
    public string NameHmac { get; set; }
    public string? ValueCipher { get; set; }
}