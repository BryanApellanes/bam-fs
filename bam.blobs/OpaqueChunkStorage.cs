using System.Security.Cryptography;
using System.Text;
using Bam.Blobs;
using Bam.Blobs.Data;
using Bam.Blobs.Data.Dao.Repository;
using Bam.Net.CoreServices.Files;
using Bam.Storage;

namespace Bam.Files;

public class OpaqueChunkStorage : IChunkStorage
{
    public OpaqueChunkStorage(IHmacKeyProvider hmacKeyProvider, BlobDataRepository? blobRepository = null)
    {
        this.HmacKeyProvider = hmacKeyProvider;
        this.HMAC = new HMACSHA256(hmacKeyProvider.GetHmacKey());
        this.BlobDataRepository = blobRepository ?? new BlobDataRepository();
    }
    private HMAC HMAC { get; set; }
    private IHmacKeyProvider HmacKeyProvider { get; set; }
    
    private BlobDataRepository BlobDataRepository { get; set; }
    
    public IChunk? GetChunk(string hash)
    {
        byte[] hashBytes = Encoding.ASCII.GetBytes(hash);
        string hex = HMAC.ComputeHash(hashBytes).ToHexString();
        throw new NotImplementedException();
    }

    public void SetChunk(IChunk chunk)
    {
        OpaqueKeyValueData data = new OpaqueKeyValueData();
        byte[] hashBytes = Encoding.ASCII.GetBytes(chunk.ChunkHash);
        string hmacKey = HMAC.ComputeHash(hashBytes).ToHexString();
        
        data.Key = hmacKey;
        
    }
}