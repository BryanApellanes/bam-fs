﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bam.Chunking
{
    public interface IChunkable
    {
        IChunk ToChunk();
    }
}
