using Bam.Data.Repositories;
using Bam.Encryption;
using Bam.Encryption.Data;

namespace Bam.Blobs.Profiles.Data.Local;

public class BlobProfileDelegatedKeySetData : KeyedAuditRepoData
{
    public BlobProfileDelegatedKeySetData(RsaKeyLength keyLength = RsaKeyLength._2048): this(keyLength, false)
    {
    }

    public BlobProfileDelegatedKeySetData(RsaKeyLength keyLength, bool initialize)
    {
        this.RsaKeyLength = keyLength;
        
        if (initialize)
        {
            Initialize();
        }
    }

    protected void Initialize()
    {
        KeySet keySet = new KeySet(this.RsaKeyLength, true, true);
        RsaPrivateKey = keySet.RsaKey;
        RsaPublicKey = RsaPrivateKey.ToKeyPair().PublicKeyToPem();
        Handle = RsaPublicKey.Sha256();
        AesKey = keySet.AesKey;
        AesIv = keySet.AesIV;
    }
    
    [CompositeKey]
    public string Handle { get; set; }
    
    public RsaKeyLength RsaKeyLength { get; set; }
    
    public string RsaPrivateKey { get; set; }
    
    public string RsaPublicKey { get; set; }
    
    public string AesKey { get; set; }
    public string AesIv { get; set; }
}