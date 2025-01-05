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
    public class OpaqueKeyValueDataQuery: Query<OpaqueKeyValueDataColumns, OpaqueKeyValueData>
    { 
		public OpaqueKeyValueDataQuery(){}
		public OpaqueKeyValueDataQuery(WhereDelegate<OpaqueKeyValueDataColumns> where, OrderBy<OpaqueKeyValueDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }
		public OpaqueKeyValueDataQuery(Func<OpaqueKeyValueDataColumns, QueryFilter<OpaqueKeyValueDataColumns>> where, OrderBy<OpaqueKeyValueDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }		
		public OpaqueKeyValueDataQuery(Delegate where, Database db = null) : base(where, db) { }
		
        public static OpaqueKeyValueDataQuery Where(WhereDelegate<OpaqueKeyValueDataColumns> where)
        {
            return Where(where, null, null);
        }

        public static OpaqueKeyValueDataQuery Where(WhereDelegate<OpaqueKeyValueDataColumns> where, OrderBy<OpaqueKeyValueDataColumns> orderBy = null, Database db = null)
        {
            return new OpaqueKeyValueDataQuery(where, orderBy, db);
        }

		public OpaqueKeyValueDataCollection Execute()
		{
			return new OpaqueKeyValueDataCollection(this, true);
		}
    }
}