using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bam.Blobs;
using Bam.Blobs.Data;

//using Bam.Net.Services.Data;

namespace Bam.Blobs
{
    /// <summary>
    /// Represents a local file and its chunks.
    /// </summary>
    public class FileBlob : Blob
    {
        public FileBlob(FileInfo file, int chunkLength = 256000)
        {
            Args.ThrowIfNull(file, "file");
            Args.ThrowIf(!file.Exists, "File {0} doesn't exist", file.FullName);
            File = file;
            Title = file.Name;
            Directory = file.Directory?.FullName;
            ChunkLength = chunkLength;
            BlobHash = file.Sha256();
            Length = file.Length;
            WholeChunkCount = Math.Floor((decimal)file.Length / (decimal)chunkLength);
            TailLength = Length % ChunkLength;
            PartialTail = TailLength > 0;
        }

        public string Title { get; set; }
        
        /// <summary>
        /// Gets the directory.
        /// </summary>
        public string? Directory { get; }
        public int ChunkLength { get; }
        
        public string BlobHash { get; }

        public long Length { get; }

        public long ChunkCount
        {
            get
            {
                if (PartialTail)
                {
                    return (long)WholeChunkCount + 1;
                }
                return (long)WholeChunkCount;
            }
        }

        public FileChunk this[int chunkIndex]
        {
            get
            {
                FileChunk chunk = new FileChunk()
                {
                    ChunkIndex = chunkIndex,
                    FileHash = BlobHash,
                    Data = ReadChunk(chunkIndex, out long streamIndex),
                    StreamIndex = streamIndex
                };
                chunk.ChunkLength = chunk.Data.Length;
                return chunk;
            }
        }

        public byte[] ReadChunk(int chunkIndex, out long streamIndex)
        {
            Args.ThrowIf<ArgumentOutOfRangeException>(chunkIndex < 0 || chunkIndex > (ChunkCount - 1), "ChunkIndex out of range: {0}", chunkIndex);
            if (PartialTail && chunkIndex == ChunkCount - 1)
            {
                return ReadTailFileSystemChunk(out streamIndex);
            }
            else
            {
                return ReadWholeFileSystemChunk(chunkIndex, out streamIndex);
            }
        }

        protected internal decimal WholeChunkCount { get; set; }
        protected internal long TailLength { get; set; }
        protected internal bool PartialTail { get; set; }
        protected long TailStreamIndex => (long)WholeChunkCount * ChunkLength;

        protected FileInfo File { get; set; }
        private byte[] ReadWholeFileSystemChunk(int chunkIndex, out long streamIndex)
        {
            streamIndex = chunkIndex * ChunkLength;
            byte[] buffer = new byte[ChunkLength];
            using (FileStream fs = new FileStream(File.FullName, FileMode.Open, FileAccess.Read))
            {
                fs.Seek(streamIndex, SeekOrigin.Begin);
                fs.Read(buffer, 0, ChunkLength);
            }

            return buffer;
        }

        private byte[] ReadTailFileSystemChunk(out long streamIndex)
        {
            streamIndex = TailStreamIndex;
            byte[] buffer = new byte[TailLength];
            using (FileStream fs = new FileStream(File.FullName, FileMode.Open, FileAccess.Read))
            {
                fs.Seek(TailStreamIndex, SeekOrigin.Begin);
                fs.Read(buffer, 0, (int)TailLength);
            }
            return buffer;            
        }
    }
}
