/*
	This file was generated and should not be modified directly
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Bam.Data;

namespace Bam.Blobs.Data.Local.Dao
{
    public class BlobPropertyDataPagedQuery: PagedQuery<BlobPropertyDataColumns, BlobPropertyData>
    { 
		public BlobPropertyDataPagedQuery(BlobPropertyDataColumns orderByColumn,BlobPropertyDataQuery query, Database db = null) : base(orderByColumn, query, db) { }
    }
}