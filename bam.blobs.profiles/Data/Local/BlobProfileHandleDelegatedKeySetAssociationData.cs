using Bam.Data.Repositories;

namespace Bam.Blobs.Profiles.Data.Local;

public class BlobProfileHandleDelegatedKeySetAssociationData : KeyedAuditRepoData
{
    public string ProfileHandle { get; set; }
    public string KeySetHandle { get; set; }
}