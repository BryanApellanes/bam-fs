using Bam.Data.Repositories;

namespace Bam.Blobs.Profiles.Data.Local;

public class BlobProfileHandleData : KeyedAuditRepoData
{
    [CompositeKey]
    public string Handle { get; set; }    
}