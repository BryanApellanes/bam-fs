using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Bam.Data;

namespace Bam.Blobs.Data.Distributed.Dao
{
    public class OpaqueChunkDataCollection: DaoCollection<OpaqueChunkDataColumns, OpaqueChunkData>
    { 
		public OpaqueChunkDataCollection(){}
		public OpaqueChunkDataCollection(IDatabase db, DataTable table, IDao dao = null, string rc = null) : base(db, table, dao, rc) { }
		public OpaqueChunkDataCollection(DataTable table, IDao dao = null, string rc = null) : base(table, dao, rc) { }
		public OpaqueChunkDataCollection(IQuery<OpaqueChunkDataColumns, OpaqueChunkData> q, Bam.Data.Dao dao = null, string rc = null) : base(q, dao, rc) { }
		public OpaqueChunkDataCollection(IDatabase db, IQuery<OpaqueChunkDataColumns, OpaqueChunkData> q, bool load) : base(db, q, load) { }
		public OpaqueChunkDataCollection(IQuery<OpaqueChunkDataColumns, OpaqueChunkData> q, bool load) : base(q, load) { }
    }
}