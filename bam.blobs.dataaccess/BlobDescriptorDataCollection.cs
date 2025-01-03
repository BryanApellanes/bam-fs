using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Bam.Data;

namespace Bam.Blobs.Data.Dao
{
    public class BlobDescriptorDataCollection: DaoCollection<BlobDescriptorDataColumns, BlobDescriptorData>
    { 
		public BlobDescriptorDataCollection(){}
		public BlobDescriptorDataCollection(IDatabase db, DataTable table, IDao dao = null, string rc = null) : base(db, table, dao, rc) { }
		public BlobDescriptorDataCollection(DataTable table, IDao dao = null, string rc = null) : base(table, dao, rc) { }
		public BlobDescriptorDataCollection(IQuery<BlobDescriptorDataColumns, BlobDescriptorData> q, Bam.Data.Dao dao = null, string rc = null) : base(q, dao, rc) { }
		public BlobDescriptorDataCollection(IDatabase db, IQuery<BlobDescriptorDataColumns, BlobDescriptorData> q, bool load) : base(db, q, load) { }
		public BlobDescriptorDataCollection(IQuery<BlobDescriptorDataColumns, BlobDescriptorData> q, bool load) : base(q, load) { }
    }
}