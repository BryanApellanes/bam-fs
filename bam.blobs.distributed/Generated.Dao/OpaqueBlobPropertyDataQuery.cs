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
    public class OpaqueBlobPropertyDataQuery: Query<OpaqueBlobPropertyDataColumns, OpaqueBlobPropertyData>
    { 
		public OpaqueBlobPropertyDataQuery(){}
		public OpaqueBlobPropertyDataQuery(WhereDelegate<OpaqueBlobPropertyDataColumns> where, OrderBy<OpaqueBlobPropertyDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }
		public OpaqueBlobPropertyDataQuery(Func<OpaqueBlobPropertyDataColumns, QueryFilter<OpaqueBlobPropertyDataColumns>> where, OrderBy<OpaqueBlobPropertyDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }		
		public OpaqueBlobPropertyDataQuery(Delegate where, Database db = null) : base(where, db) { }
		
        public static OpaqueBlobPropertyDataQuery Where(WhereDelegate<OpaqueBlobPropertyDataColumns> where)
        {
            return Where(where, null, null);
        }

        public static OpaqueBlobPropertyDataQuery Where(WhereDelegate<OpaqueBlobPropertyDataColumns> where, OrderBy<OpaqueBlobPropertyDataColumns> orderBy = null, Database db = null)
        {
            return new OpaqueBlobPropertyDataQuery(where, orderBy, db);
        }

		public OpaqueBlobPropertyDataCollection Execute()
		{
			return new OpaqueBlobPropertyDataCollection(this, true);
		}
    }
}