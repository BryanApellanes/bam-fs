using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Bam.Data;

namespace Bam.Blobs.Data.Dao
{
    public class OpaqueKeyValueDataCollection: DaoCollection<OpaqueKeyValueDataColumns, OpaqueKeyValueData>
    { 
		public OpaqueKeyValueDataCollection(){}
		public OpaqueKeyValueDataCollection(IDatabase db, DataTable table, IDao dao = null, string rc = null) : base(db, table, dao, rc) { }
		public OpaqueKeyValueDataCollection(DataTable table, IDao dao = null, string rc = null) : base(table, dao, rc) { }
		public OpaqueKeyValueDataCollection(IQuery<OpaqueKeyValueDataColumns, OpaqueKeyValueData> q, Bam.Data.Dao dao = null, string rc = null) : base(q, dao, rc) { }
		public OpaqueKeyValueDataCollection(IDatabase db, IQuery<OpaqueKeyValueDataColumns, OpaqueKeyValueData> q, bool load) : base(db, q, load) { }
		public OpaqueKeyValueDataCollection(IQuery<OpaqueKeyValueDataColumns, OpaqueKeyValueData> q, bool load) : base(q, load) { }
    }
}