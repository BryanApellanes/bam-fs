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
    public class OpaqueBlobChunkDataQuery: Query<OpaqueBlobChunkDataColumns, OpaqueBlobChunkData>
    { 
		public OpaqueBlobChunkDataQuery(){}
		public OpaqueBlobChunkDataQuery(WhereDelegate<OpaqueBlobChunkDataColumns> where, OrderBy<OpaqueBlobChunkDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }
		public OpaqueBlobChunkDataQuery(Func<OpaqueBlobChunkDataColumns, QueryFilter<OpaqueBlobChunkDataColumns>> where, OrderBy<OpaqueBlobChunkDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }		
		public OpaqueBlobChunkDataQuery(Delegate where, Database db = null) : base(where, db) { }
		
        public static OpaqueBlobChunkDataQuery Where(WhereDelegate<OpaqueBlobChunkDataColumns> where)
        {
            return Where(where, null, null);
        }

        public static OpaqueBlobChunkDataQuery Where(WhereDelegate<OpaqueBlobChunkDataColumns> where, OrderBy<OpaqueBlobChunkDataColumns> orderBy = null, Database db = null)
        {
            return new OpaqueBlobChunkDataQuery(where, orderBy, db);
        }

		public OpaqueBlobChunkDataCollection Execute()
		{
			return new OpaqueBlobChunkDataCollection(this, true);
		}
    }
}