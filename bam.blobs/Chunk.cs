using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bam.Net.CoreServices.Files;

namespace Bam.Blobs
{
    public class Chunk : IChunk
    {
        public string ChunkHash { get; set; }
        public byte[] Data { get; set; }
    }

}
