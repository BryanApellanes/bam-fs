using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Bam.Data;

namespace Bam.Blobs.Data.Distributed.Dao
{
    public class OpaqueBlobPropertyDataCollection: DaoCollection<OpaqueBlobPropertyDataColumns, OpaqueBlobPropertyData>
    { 
		public OpaqueBlobPropertyDataCollection(){}
		public OpaqueBlobPropertyDataCollection(IDatabase db, DataTable table, IDao dao = null, string rc = null) : base(db, table, dao, rc) { }
		public OpaqueBlobPropertyDataCollection(DataTable table, IDao dao = null, string rc = null) : base(table, dao, rc) { }
		public OpaqueBlobPropertyDataCollection(IQuery<OpaqueBlobPropertyDataColumns, OpaqueBlobPropertyData> q, Bam.Data.Dao dao = null, string rc = null) : base(q, dao, rc) { }
		public OpaqueBlobPropertyDataCollection(IDatabase db, IQuery<OpaqueBlobPropertyDataColumns, OpaqueBlobPropertyData> q, bool load) : base(db, q, load) { }
		public OpaqueBlobPropertyDataCollection(IQuery<OpaqueBlobPropertyDataColumns, OpaqueBlobPropertyData> q, bool load) : base(q, load) { }
    }
}