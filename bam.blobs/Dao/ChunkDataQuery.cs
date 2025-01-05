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
    public class ChunkDataQuery: Query<ChunkDataColumns, ChunkData>
    { 
		public ChunkDataQuery(){}
		public ChunkDataQuery(WhereDelegate<ChunkDataColumns> where, OrderBy<ChunkDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }
		public ChunkDataQuery(Func<ChunkDataColumns, QueryFilter<ChunkDataColumns>> where, OrderBy<ChunkDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }		
		public ChunkDataQuery(Delegate where, Database db = null) : base(where, db) { }
		
        public static ChunkDataQuery Where(WhereDelegate<ChunkDataColumns> where)
        {
            return Where(where, null, null);
        }

        public static ChunkDataQuery Where(WhereDelegate<ChunkDataColumns> where, OrderBy<ChunkDataColumns> orderBy = null, Database db = null)
        {
            return new ChunkDataQuery(where, orderBy, db);
        }

		public ChunkDataCollection Execute()
		{
			return new ChunkDataCollection(this, true);
		}
    }
}