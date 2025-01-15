using Bam.Data.Repositories;

namespace Bam.Blobs.Data.Distributed;

public class OpaqueBlobHandleData : RepoData
{
    public string AuthorHandleHmac { get; set; }
    public string BlobHashHmac { get; set; }
}