using Bam.Data.Repositories;
using Bam.Net.CoreServices.Files;

namespace Bam.Files.Data
{
    /// <summary>
    /// A descriptor for the relationship between
    /// a BlobData and a ChunkData instance.  There
    /// will be multiple instances of these
    /// relating one file to many ChunkData instances
    /// </summary>
    [Serializable]
    public class BlobChunkAssociationData: RepoData
    {
        /// <summary>
        /// Gets or sets the Sha256 hash of the blob.
        /// </summary>
        public string BlobHash { get; set; }
        
        /// <summary>
        /// Gets or sets the Sha256 hash of the chunk.
        /// </summary>
        public string ChunkHash { get; set; }
        
        /// <summary>
        /// Gets or sets the index of the chunk in the blob.
        /// </summary>
        public long ChunkIndex { get; set; }
        
        /// <summary>
        /// The index in the Blob stream
        /// where this chunk begins
        /// </summary>
        public long StreamIndex { get; set; }

        public byte[] GetData(IFileService fileService)
        {
            return fileService.GetChunkData(ChunkHash).Data.FromBase64();
        }
    }
}
