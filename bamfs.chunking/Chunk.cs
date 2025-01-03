using Bam.Net.CoreServices.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bam.Chunking;

namespace Bam.Net.Services.Chunking
{
    public class Chunk : IChunk
    {
        public string Hash { get; set; }
        public byte[] Data { get; set; }

        public IChunk ToChunk()
        {
            return this;
        }
    }
}
