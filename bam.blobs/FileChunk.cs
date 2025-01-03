/*
	Copyright © Bryan Apellanes 2015  
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Bam.Blobs.Data;
using Bam.Net;
using Bam.Net.CoreServices.Files;

namespace Bam.Blobs
{
    /// <summary>
    /// A chunk or segment of a file
    /// </summary>
	[Serializable]
	public class FileChunk: IChunk
	{
		public FileChunk()
		{
		}
        
        public string FileHash { get; set; }

        /// <summary>
        /// Hash of this chunks ByteData
        /// </summary>
        public string ChunkHash { get; set; }
        
        /// <summary>
        /// The index of this chunk relative to
        /// all file chunks
        /// </summary>
		public long ChunkIndex { get; set; }

        /// <summary>
        /// The index in the file stream
        /// where this chunk begins
        /// </summary>
        public long StreamIndex { get; set; }

        /// <summary>
        /// The length of the byte[] data, Data
        /// base 64 decoded
        /// </summary>
		public int ChunkLength
		{
			get;
			set;
		}

        string _data;
        /// <summary>
        /// The base 64 encoded data of this 
        /// chunk
        /// </summary>
        public string DataBase64
        {
            get => _data;
            set
            {
                _data = value;
                _byteData = _data.FromBase64();
                SetChunkHash();
            }
        }

        byte[] _byteData;
        public byte[] Data
        {
            get => _byteData;
            set
            {
                _byteData = value;
                _data = _byteData.ToBase64();
                SetChunkHash();
            }
        }

        public BlobChunkAssociationData ToChunkDataDescriptor()
        {
            return new BlobChunkAssociationData
            {
                BlobHash = FileHash,
                ChunkHash = ChunkHash,
                ChunkIndex = ChunkIndex,
                StreamIndex = StreamIndex
            };
        }

        public ChunkData ToChunkData()
        {
            return new ChunkData
            {
                ChunkHash = ChunkHash,
                ChunkLength = ChunkLength,
                Data = DataBase64
            };
        }

        private void SetChunkHash()
        {
            ChunkHash = _byteData.Sha256();
        }
    }
}
