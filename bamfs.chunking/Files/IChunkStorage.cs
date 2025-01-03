using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bam.Chunking
{
    public interface IChunkStorage
    {
        IChunk GetChunk(string hash);
        void SetChunk(IChunk chunk);
    }
}
