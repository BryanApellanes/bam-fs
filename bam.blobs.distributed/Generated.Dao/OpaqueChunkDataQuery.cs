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
    public class OpaqueChunkDataQuery: Query<OpaqueChunkDataColumns, OpaqueChunkData>
    { 
		public OpaqueChunkDataQuery(){}
		public OpaqueChunkDataQuery(WhereDelegate<OpaqueChunkDataColumns> where, OrderBy<OpaqueChunkDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }
		public OpaqueChunkDataQuery(Func<OpaqueChunkDataColumns, QueryFilter<OpaqueChunkDataColumns>> where, OrderBy<OpaqueChunkDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }		
		public OpaqueChunkDataQuery(Delegate where, Database db = null) : base(where, db) { }
		
        public static OpaqueChunkDataQuery Where(WhereDelegate<OpaqueChunkDataColumns> where)
        {
            return Where(where, null, null);
        }

        public static OpaqueChunkDataQuery Where(WhereDelegate<OpaqueChunkDataColumns> where, OrderBy<OpaqueChunkDataColumns> orderBy = null, Database db = null)
        {
            return new OpaqueChunkDataQuery(where, orderBy, db);
        }

		public OpaqueChunkDataCollection Execute()
		{
			return new OpaqueChunkDataCollection(this, true);
		}
    }
}