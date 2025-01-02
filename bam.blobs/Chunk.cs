using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bam.Net.CoreServices.Files;

namespace Bam.Files
{
    internal class Chunk : IChunk, IChunkable
    {
        public string Hash { get; set; }
        public byte[] Data { get; set; }

        public IChunk ToChunk()
        {
            return this;
        }
    }

}
