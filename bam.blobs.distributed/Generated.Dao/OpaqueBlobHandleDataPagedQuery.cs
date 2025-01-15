/*
	This file was generated and should not be modified directly
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Bam.Data;

namespace Bam.Blobs.Data.Distributed.Dao
{
    public class OpaqueBlobHandleDataPagedQuery: PagedQuery<OpaqueBlobHandleDataColumns, OpaqueBlobHandleData>
    { 
		public OpaqueBlobHandleDataPagedQuery(OpaqueBlobHandleDataColumns orderByColumn,OpaqueBlobHandleDataQuery query, Database db = null) : base(orderByColumn, query, db) { }
    }
}