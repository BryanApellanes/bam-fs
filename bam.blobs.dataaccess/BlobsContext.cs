/*
	This file was generated and should not be modified directly
*/
// model is SchemaDefinition
using System;
using System.Data;
using System.Data.Common;
using Bam;
using Bam.Data;
using Bam.Data.Qi;

namespace Bam.Blobs.Data.Dao
{
	// schema = Blobs
    public static class BlobsContext
    {
		public static string ConnectionName
		{
			get
			{
				return "Blobs";
			}
		}

		public static IDatabase Db
		{
			get
			{
				return Bam.Data.Db.For(ConnectionName);
			}
		}


	public class BlobChunkAssociationDataQueryContext
	{
			public BlobChunkAssociationDataCollection Where(WhereDelegate<BlobChunkAssociationDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkAssociationData.Where(where, db);
			}
		   
			public BlobChunkAssociationDataCollection Where(WhereDelegate<BlobChunkAssociationDataColumns> where, OrderBy<BlobChunkAssociationDataColumns> orderBy = null, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkAssociationData.Where(where, orderBy, db);
			}

			public BlobChunkAssociationData OneWhere(WhereDelegate<BlobChunkAssociationDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkAssociationData.OneWhere(where, db);
			}

			public static BlobChunkAssociationData GetOneWhere(WhereDelegate<BlobChunkAssociationDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkAssociationData.GetOneWhere(where, db);
			}
		
			public BlobChunkAssociationData FirstOneWhere(WhereDelegate<BlobChunkAssociationDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkAssociationData.FirstOneWhere(where, db);
			}

			public BlobChunkAssociationDataCollection Top(int count, WhereDelegate<BlobChunkAssociationDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkAssociationData.Top(count, where, db);
			}

			public BlobChunkAssociationDataCollection Top(int count, WhereDelegate<BlobChunkAssociationDataColumns> where, OrderBy<BlobChunkAssociationDataColumns> orderBy, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkAssociationData.Top(count, where, orderBy, db);
			}

			public long Count(WhereDelegate<BlobChunkAssociationDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkAssociationData.Count(where, db);
			}
	}

	static BlobChunkAssociationDataQueryContext _blobChunkAssociationDatas;
	static object _blobChunkAssociationDatasLock = new object();
	public static BlobChunkAssociationDataQueryContext BlobChunkAssociationDatas
	{
		get
		{
			return _blobChunkAssociationDatasLock.DoubleCheckLock<BlobChunkAssociationDataQueryContext>(ref _blobChunkAssociationDatas, () => new BlobChunkAssociationDataQueryContext());
		}
	}
	public class BlobDescriptorDataQueryContext
	{
			public BlobDescriptorDataCollection Where(WhereDelegate<BlobDescriptorDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobDescriptorData.Where(where, db);
			}
		   
			public BlobDescriptorDataCollection Where(WhereDelegate<BlobDescriptorDataColumns> where, OrderBy<BlobDescriptorDataColumns> orderBy = null, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobDescriptorData.Where(where, orderBy, db);
			}

			public BlobDescriptorData OneWhere(WhereDelegate<BlobDescriptorDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobDescriptorData.OneWhere(where, db);
			}

			public static BlobDescriptorData GetOneWhere(WhereDelegate<BlobDescriptorDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobDescriptorData.GetOneWhere(where, db);
			}
		
			public BlobDescriptorData FirstOneWhere(WhereDelegate<BlobDescriptorDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobDescriptorData.FirstOneWhere(where, db);
			}

			public BlobDescriptorDataCollection Top(int count, WhereDelegate<BlobDescriptorDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobDescriptorData.Top(count, where, db);
			}

			public BlobDescriptorDataCollection Top(int count, WhereDelegate<BlobDescriptorDataColumns> where, OrderBy<BlobDescriptorDataColumns> orderBy, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobDescriptorData.Top(count, where, orderBy, db);
			}

			public long Count(WhereDelegate<BlobDescriptorDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobDescriptorData.Count(where, db);
			}
	}

	static BlobDescriptorDataQueryContext _blobDescriptorDatas;
	static object _blobDescriptorDatasLock = new object();
	public static BlobDescriptorDataQueryContext BlobDescriptorDatas
	{
		get
		{
			return _blobDescriptorDatasLock.DoubleCheckLock<BlobDescriptorDataQueryContext>(ref _blobDescriptorDatas, () => new BlobDescriptorDataQueryContext());
		}
	}
	public class BlobPropertyDataQueryContext
	{
			public BlobPropertyDataCollection Where(WhereDelegate<BlobPropertyDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobPropertyData.Where(where, db);
			}
		   
			public BlobPropertyDataCollection Where(WhereDelegate<BlobPropertyDataColumns> where, OrderBy<BlobPropertyDataColumns> orderBy = null, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobPropertyData.Where(where, orderBy, db);
			}

			public BlobPropertyData OneWhere(WhereDelegate<BlobPropertyDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobPropertyData.OneWhere(where, db);
			}

			public static BlobPropertyData GetOneWhere(WhereDelegate<BlobPropertyDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobPropertyData.GetOneWhere(where, db);
			}
		
			public BlobPropertyData FirstOneWhere(WhereDelegate<BlobPropertyDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobPropertyData.FirstOneWhere(where, db);
			}

			public BlobPropertyDataCollection Top(int count, WhereDelegate<BlobPropertyDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobPropertyData.Top(count, where, db);
			}

			public BlobPropertyDataCollection Top(int count, WhereDelegate<BlobPropertyDataColumns> where, OrderBy<BlobPropertyDataColumns> orderBy, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobPropertyData.Top(count, where, orderBy, db);
			}

			public long Count(WhereDelegate<BlobPropertyDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobPropertyData.Count(where, db);
			}
	}

	static BlobPropertyDataQueryContext _blobPropertyDatas;
	static object _blobPropertyDatasLock = new object();
	public static BlobPropertyDataQueryContext BlobPropertyDatas
	{
		get
		{
			return _blobPropertyDatasLock.DoubleCheckLock<BlobPropertyDataQueryContext>(ref _blobPropertyDatas, () => new BlobPropertyDataQueryContext());
		}
	}
	public class ChunkDataQueryContext
	{
			public ChunkDataCollection Where(WhereDelegate<ChunkDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.ChunkData.Where(where, db);
			}
		   
			public ChunkDataCollection Where(WhereDelegate<ChunkDataColumns> where, OrderBy<ChunkDataColumns> orderBy = null, Database db = null)
			{
				return Bam.Blobs.Data.Dao.ChunkData.Where(where, orderBy, db);
			}

			public ChunkData OneWhere(WhereDelegate<ChunkDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.ChunkData.OneWhere(where, db);
			}

			public static ChunkData GetOneWhere(WhereDelegate<ChunkDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.ChunkData.GetOneWhere(where, db);
			}
		
			public ChunkData FirstOneWhere(WhereDelegate<ChunkDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.ChunkData.FirstOneWhere(where, db);
			}

			public ChunkDataCollection Top(int count, WhereDelegate<ChunkDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.ChunkData.Top(count, where, db);
			}

			public ChunkDataCollection Top(int count, WhereDelegate<ChunkDataColumns> where, OrderBy<ChunkDataColumns> orderBy, Database db = null)
			{
				return Bam.Blobs.Data.Dao.ChunkData.Top(count, where, orderBy, db);
			}

			public long Count(WhereDelegate<ChunkDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.ChunkData.Count(where, db);
			}
	}

	static ChunkDataQueryContext _chunkDatas;
	static object _chunkDatasLock = new object();
	public static ChunkDataQueryContext ChunkDatas
	{
		get
		{
			return _chunkDatasLock.DoubleCheckLock<ChunkDataQueryContext>(ref _chunkDatas, () => new ChunkDataQueryContext());
		}
	}
    }
}																								
