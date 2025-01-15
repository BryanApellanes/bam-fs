using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Bam.Data;

namespace Bam.Blobs.Data.Distributed.Dao
{
    public class OpaqueBlobHandleDataCollection: DaoCollection<OpaqueBlobHandleDataColumns, OpaqueBlobHandleData>
    { 
		public OpaqueBlobHandleDataCollection(){}
		public OpaqueBlobHandleDataCollection(IDatabase db, DataTable table, IDao dao = null, string rc = null) : base(db, table, dao, rc) { }
		public OpaqueBlobHandleDataCollection(DataTable table, IDao dao = null, string rc = null) : base(table, dao, rc) { }
		public OpaqueBlobHandleDataCollection(IQuery<OpaqueBlobHandleDataColumns, OpaqueBlobHandleData> q, Bam.Data.Dao dao = null, string rc = null) : base(q, dao, rc) { }
		public OpaqueBlobHandleDataCollection(IDatabase db, IQuery<OpaqueBlobHandleDataColumns, OpaqueBlobHandleData> q, bool load) : base(db, q, load) { }
		public OpaqueBlobHandleDataCollection(IQuery<OpaqueBlobHandleDataColumns, OpaqueBlobHandleData> q, bool load) : base(q, load) { }
    }
}