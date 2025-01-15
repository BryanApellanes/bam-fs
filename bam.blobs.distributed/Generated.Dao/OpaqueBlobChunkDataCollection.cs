using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Bam.Data;

namespace Bam.Blobs.Data.Distributed.Dao
{
    public class OpaqueBlobChunkDataCollection: DaoCollection<OpaqueBlobChunkDataColumns, OpaqueBlobChunkData>
    { 
		public OpaqueBlobChunkDataCollection(){}
		public OpaqueBlobChunkDataCollection(IDatabase db, DataTable table, IDao dao = null, string rc = null) : base(db, table, dao, rc) { }
		public OpaqueBlobChunkDataCollection(DataTable table, IDao dao = null, string rc = null) : base(table, dao, rc) { }
		public OpaqueBlobChunkDataCollection(IQuery<OpaqueBlobChunkDataColumns, OpaqueBlobChunkData> q, Bam.Data.Dao dao = null, string rc = null) : base(q, dao, rc) { }
		public OpaqueBlobChunkDataCollection(IDatabase db, IQuery<OpaqueBlobChunkDataColumns, OpaqueBlobChunkData> q, bool load) : base(db, q, load) { }
		public OpaqueBlobChunkDataCollection(IQuery<OpaqueBlobChunkDataColumns, OpaqueBlobChunkData> q, bool load) : base(q, load) { }
    }
}