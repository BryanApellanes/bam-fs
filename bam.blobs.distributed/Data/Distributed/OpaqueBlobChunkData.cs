
using Bam.Data.Repositories;

namespace Bam.Blobs.Data.Distributed;

public class OpaqueBlobChunkData: RepoData
{
    public string ChunkHashHmac { get; set; }
    public string DataCipher { get; set; }
}