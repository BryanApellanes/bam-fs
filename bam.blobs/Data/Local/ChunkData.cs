﻿using Bam.Data.Repositories;
using Bam.Net.CoreServices.Files;

namespace Bam.Blobs.Data
{
    /// <summary>
    /// Represent an arbitrary chunk of data (base 64 encoded)
    /// identified by its hash (Sha256)
    /// </summary>
    [Serializable]
    public class ChunkData: RepoData
    {
        /// <summary>
        /// The Sha256 hash of the base 64 decoded
        /// value of this chunks Data
        /// </summary>
        public string ChunkHash { get; set; }

        /// <summary>
        /// Base64 encoded data.
        /// </summary>
        public string Data { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is ChunkData data)
            {
                return data.ChunkHash.Equals(ChunkHash);
            }
            return false;
        }

        public IChunk ToChunk()
        {
            return new Chunk { ChunkHash = ChunkHash, Data = Data.FromBase64() };
        }

        public static ChunkData FromChunk(IChunk chunk)
        {
            return new ChunkData { ChunkHash = chunk.ChunkHash, Data = chunk.Data.ToBase64() };
        }

        public override int GetHashCode()
        {
            return ChunkHash.GetHashCode();
        }
    }
}
