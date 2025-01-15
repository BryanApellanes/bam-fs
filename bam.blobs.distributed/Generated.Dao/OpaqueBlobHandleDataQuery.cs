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
    public class OpaqueBlobHandleDataQuery: Query<OpaqueBlobHandleDataColumns, OpaqueBlobHandleData>
    { 
		public OpaqueBlobHandleDataQuery(){}
		public OpaqueBlobHandleDataQuery(WhereDelegate<OpaqueBlobHandleDataColumns> where, OrderBy<OpaqueBlobHandleDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }
		public OpaqueBlobHandleDataQuery(Func<OpaqueBlobHandleDataColumns, QueryFilter<OpaqueBlobHandleDataColumns>> where, OrderBy<OpaqueBlobHandleDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }		
		public OpaqueBlobHandleDataQuery(Delegate where, Database db = null) : base(where, db) { }
		
        public static OpaqueBlobHandleDataQuery Where(WhereDelegate<OpaqueBlobHandleDataColumns> where)
        {
            return Where(where, null, null);
        }

        public static OpaqueBlobHandleDataQuery Where(WhereDelegate<OpaqueBlobHandleDataColumns> where, OrderBy<OpaqueBlobHandleDataColumns> orderBy = null, Database db = null)
        {
            return new OpaqueBlobHandleDataQuery(where, orderBy, db);
        }

		public OpaqueBlobHandleDataCollection Execute()
		{
			return new OpaqueBlobHandleDataCollection(this, true);
		}
    }
}