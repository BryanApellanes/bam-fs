using Bam.Data.Repositories;

namespace Bam.Blobs.Data
{
    [Serializable]
    public class BlobDescriptorData: RepoData
    {
        public string BlobHash { get; set; }

        public string Title { get; set; }
        
        public string Description { get; set; }
        
        public long Length { get; set; }
        
        public long ChunkCount { get; set; }
        
        /// <summary>
        /// Gets or sets the chunk length.
        /// </summary>
        public int ChunkLength { get; set; }
        
        public override bool Equals(object obj)
        {
            if (obj is BlobDescriptorData o)
            {
                return o.BlobHash.Equals(BlobHash);
            }
            return false;
        }
    }
}
