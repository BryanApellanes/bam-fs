﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bam.Net.Services.Chunking
{
    public class ChunkExceptionEventArgs: EventArgs
    {
        public string Hash { get; set; }

    }
}
