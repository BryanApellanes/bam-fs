/*
	This file was generated and should not be modified directly
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Bam.Data;

namespace Bam.Blobs.Data.Dao
{
    public class ChunkDataPagedQuery: PagedQuery<ChunkDataColumns, ChunkData>
    { 
		public ChunkDataPagedQuery(ChunkDataColumns orderByColumn,ChunkDataQuery query, Database db = null) : base(orderByColumn, query, db) { }
    }
}