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
    public class OpaqueKeyValueDataPagedQuery: PagedQuery<OpaqueKeyValueDataColumns, OpaqueKeyValueData>
    { 
		public OpaqueKeyValueDataPagedQuery(OpaqueKeyValueDataColumns orderByColumn,OpaqueKeyValueDataQuery query, Database db = null) : base(orderByColumn, query, db) { }
    }
}