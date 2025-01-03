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
    public class BlobDescriptorDataQuery: Query<BlobDescriptorDataColumns, BlobDescriptorData>
    { 
		public BlobDescriptorDataQuery(){}
		public BlobDescriptorDataQuery(WhereDelegate<BlobDescriptorDataColumns> where, OrderBy<BlobDescriptorDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }
		public BlobDescriptorDataQuery(Func<BlobDescriptorDataColumns, QueryFilter<BlobDescriptorDataColumns>> where, OrderBy<BlobDescriptorDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }		
		public BlobDescriptorDataQuery(Delegate where, Database db = null) : base(where, db) { }
		
        public static BlobDescriptorDataQuery Where(WhereDelegate<BlobDescriptorDataColumns> where)
        {
            return Where(where, null, null);
        }

        public static BlobDescriptorDataQuery Where(WhereDelegate<BlobDescriptorDataColumns> where, OrderBy<BlobDescriptorDataColumns> orderBy = null, Database db = null)
        {
            return new BlobDescriptorDataQuery(where, orderBy, db);
        }

		public BlobDescriptorDataCollection Execute()
		{
			return new BlobDescriptorDataCollection(this, true);
		}
    }
}