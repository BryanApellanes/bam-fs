/*
	This file was generated and should not be modified directly
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Bam.Data;

namespace Bam.Blobs.Data.Distributed.Dao
{
    public class OpaqueBlobChunkDataPagedQuery: PagedQuery<OpaqueBlobChunkDataColumns, OpaqueBlobChunkData>
    { 
		public OpaqueBlobChunkDataPagedQuery(OpaqueBlobChunkDataColumns orderByColumn,OpaqueBlobChunkDataQuery query, Database db = null) : base(orderByColumn, query, db) { }
    }
}