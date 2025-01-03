using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Bam.Data;

namespace Bam.Blobs.Data.Dao
{
    public class BlobChunkAssociationDataCollection: DaoCollection<BlobChunkAssociationDataColumns, BlobChunkAssociationData>
    { 
		public BlobChunkAssociationDataCollection(){}
		public BlobChunkAssociationDataCollection(IDatabase db, DataTable table, IDao dao = null, string rc = null) : base(db, table, dao, rc) { }
		public BlobChunkAssociationDataCollection(DataTable table, IDao dao = null, string rc = null) : base(table, dao, rc) { }
		public BlobChunkAssociationDataCollection(IQuery<BlobChunkAssociationDataColumns, BlobChunkAssociationData> q, Bam.Data.Dao dao = null, string rc = null) : base(q, dao, rc) { }
		public BlobChunkAssociationDataCollection(IDatabase db, IQuery<BlobChunkAssociationDataColumns, BlobChunkAssociationData> q, bool load) : base(db, q, load) { }
		public BlobChunkAssociationDataCollection(IQuery<BlobChunkAssociationDataColumns, BlobChunkAssociationData> q, bool load) : base(q, load) { }
    }
}