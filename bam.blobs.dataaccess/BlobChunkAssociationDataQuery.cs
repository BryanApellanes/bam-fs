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
    public class BlobChunkAssociationDataQuery: Query<BlobChunkAssociationDataColumns, BlobChunkAssociationData>
    { 
		public BlobChunkAssociationDataQuery(){}
		public BlobChunkAssociationDataQuery(WhereDelegate<BlobChunkAssociationDataColumns> where, OrderBy<BlobChunkAssociationDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }
		public BlobChunkAssociationDataQuery(Func<BlobChunkAssociationDataColumns, QueryFilter<BlobChunkAssociationDataColumns>> where, OrderBy<BlobChunkAssociationDataColumns> orderBy = null, Database db = null) : base(where, orderBy, db) { }		
		public BlobChunkAssociationDataQuery(Delegate where, Database db = null) : base(where, db) { }
		
        public static BlobChunkAssociationDataQuery Where(WhereDelegate<BlobChunkAssociationDataColumns> where)
        {
            return Where(where, null, null);
        }

        public static BlobChunkAssociationDataQuery Where(WhereDelegate<BlobChunkAssociationDataColumns> where, OrderBy<BlobChunkAssociationDataColumns> orderBy = null, Database db = null)
        {
            return new BlobChunkAssociationDataQuery(where, orderBy, db);
        }

		public BlobChunkAssociationDataCollection Execute()
		{
			return new BlobChunkAssociationDataCollection(this, true);
		}
    }
}