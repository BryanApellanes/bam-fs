using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Bam.Data;

namespace Bam.Blobs.Data.Dao
{
    public class ChunkDataCollection: DaoCollection<ChunkDataColumns, ChunkData>
    { 
		public ChunkDataCollection(){}
		public ChunkDataCollection(IDatabase db, DataTable table, IDao dao = null, string rc = null) : base(db, table, dao, rc) { }
		public ChunkDataCollection(DataTable table, IDao dao = null, string rc = null) : base(table, dao, rc) { }
		public ChunkDataCollection(IQuery<ChunkDataColumns, ChunkData> q, Bam.Data.Dao dao = null, string rc = null) : base(q, dao, rc) { }
		public ChunkDataCollection(IDatabase db, IQuery<ChunkDataColumns, ChunkData> q, bool load) : base(db, q, load) { }
		public ChunkDataCollection(IQuery<ChunkDataColumns, ChunkData> q, bool load) : base(q, load) { }
    }
}