using Bam.Blobs.Data.Local.Dao.Repository;
using Bam.Net.CoreServices.Files;

namespace Bam.Blobs;

public class BlobWriter
{
    public BlobWriter(LocalBlobDataRepository blobRepository, IChunkStorage distributedChunkStorage)
    {
        this.BlobRepository = blobRepository;
        this.DistributedChunkStorage = distributedChunkStorage;
    }
    
    public LocalBlobDataRepository BlobRepository { get; }
    public IChunkStorage DistributedChunkStorage { get; }

    /*public FileInfo WriteBlobToFile(string blobHash, string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);
        
        
    }*/
}