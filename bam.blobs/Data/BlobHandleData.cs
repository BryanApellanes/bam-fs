using Bam.Data.Repositories;
using Bam.Files;

namespace Bam.Blobs.Data
{
    [Serializable]
    public class BlobHandleData: RepoData
    {
        public string BlobHash { get; set; }
        
        public override bool Equals(object obj)
        {
            if (obj is BlobHandleData o)
            {
                return o.BlobHash.Equals(BlobHash);
            }
            return false;
        }
    }
}
