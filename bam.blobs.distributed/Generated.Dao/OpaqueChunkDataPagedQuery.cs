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
    public class OpaqueChunkDataPagedQuery: PagedQuery<OpaqueChunkDataColumns, OpaqueChunkData>
    { 
		public OpaqueChunkDataPagedQuery(OpaqueChunkDataColumns orderByColumn,OpaqueChunkDataQuery query, Database db = null) : base(orderByColumn, query, db) { }
    }
}