using Bam.Blobs.Data.Dao.Repository;
using Bam.Net.CoreServices.Files;

namespace Bam.Blobs;

public class BlobWriter
{
    public BlobWriter(BlobDataRepository blobRepository, IChunkStorage distributedChunkStorage)
    {
        this.BlobRepository = blobRepository;
        this.DistributedChunkStorage = distributedChunkStorage;
    }
    
    public BlobDataRepository BlobRepository { get; }
    public IChunkStorage DistributedChunkStorage { get; }

    /*public FileInfo WriteBlobToFile(string blobHash, string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);
        
        
    }*/
}