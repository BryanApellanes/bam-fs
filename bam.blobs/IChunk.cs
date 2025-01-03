﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bam.Net.CoreServices.Files
{
    public interface IChunk
    {
        string ChunkHash { get; set; }
        byte[] Data { get; set; }
    }
}
