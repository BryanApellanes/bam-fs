using Bam.Data.Repositories;

namespace Bam.Blobs.Data.Local
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
