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
    public class BlobChunkAssociationDataPagedQuery: PagedQuery<BlobChunkAssociationDataColumns, BlobChunkAssociationData>
    { 
		public BlobChunkAssociationDataPagedQuery(BlobChunkAssociationDataColumns orderByColumn,BlobChunkAssociationDataQuery query, Database db = null) : base(orderByColumn, query, db) { }
    }
}