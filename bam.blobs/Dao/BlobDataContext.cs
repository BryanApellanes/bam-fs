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
	// schema = BlobData
    public static class BlobDataContext
    {
		public static string ConnectionName
		{
			get
			{
				return "BlobData";
			}
		}

		public static IDatabase Db
		{
			get
			{
				return Bam.Data.Db.For(ConnectionName);
			}
		}


	public class BlobChunkDataQueryContext
	{
			public BlobChunkDataCollection Where(WhereDelegate<BlobChunkDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkData.Where(where, db);
			}
		   
			public BlobChunkDataCollection Where(WhereDelegate<BlobChunkDataColumns> where, OrderBy<BlobChunkDataColumns> orderBy = null, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkData.Where(where, orderBy, db);
			}

			public BlobChunkData OneWhere(WhereDelegate<BlobChunkDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkData.OneWhere(where, db);
			}

			public static BlobChunkData GetOneWhere(WhereDelegate<BlobChunkDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkData.GetOneWhere(where, db);
			}
		
			public BlobChunkData FirstOneWhere(WhereDelegate<BlobChunkDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkData.FirstOneWhere(where, db);
			}

			public BlobChunkDataCollection Top(int count, WhereDelegate<BlobChunkDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkData.Top(count, where, db);
			}

			public BlobChunkDataCollection Top(int count, WhereDelegate<BlobChunkDataColumns> where, OrderBy<BlobChunkDataColumns> orderBy, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkData.Top(count, where, orderBy, db);
			}

			public long Count(WhereDelegate<BlobChunkDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobChunkData.Count(where, db);
			}
	}

	static BlobChunkDataQueryContext _blobChunkDatas;
	static object _blobChunkDatasLock = new object();
	public static BlobChunkDataQueryContext BlobChunkDatas
	{
		get
		{
			return _blobChunkDatasLock.DoubleCheckLock<BlobChunkDataQueryContext>(ref _blobChunkDatas, () => new BlobChunkDataQueryContext());
		}
	}
	public class BlobHandleDataQueryContext
	{
			public BlobHandleDataCollection Where(WhereDelegate<BlobHandleDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobHandleData.Where(where, db);
			}
		   
			public BlobHandleDataCollection Where(WhereDelegate<BlobHandleDataColumns> where, OrderBy<BlobHandleDataColumns> orderBy = null, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobHandleData.Where(where, orderBy, db);
			}

			public BlobHandleData OneWhere(WhereDelegate<BlobHandleDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobHandleData.OneWhere(where, db);
			}

			public static BlobHandleData GetOneWhere(WhereDelegate<BlobHandleDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobHandleData.GetOneWhere(where, db);
			}
		
			public BlobHandleData FirstOneWhere(WhereDelegate<BlobHandleDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobHandleData.FirstOneWhere(where, db);
			}

			public BlobHandleDataCollection Top(int count, WhereDelegate<BlobHandleDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobHandleData.Top(count, where, db);
			}

			public BlobHandleDataCollection Top(int count, WhereDelegate<BlobHandleDataColumns> where, OrderBy<BlobHandleDataColumns> orderBy, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobHandleData.Top(count, where, orderBy, db);
			}

			public long Count(WhereDelegate<BlobHandleDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.BlobHandleData.Count(where, db);
			}
	}

	static BlobHandleDataQueryContext _blobHandleDatas;
	static object _blobHandleDatasLock = new object();
	public static BlobHandleDataQueryContext BlobHandleDatas
	{
		get
		{
			return _blobHandleDatasLock.DoubleCheckLock<BlobHandleDataQueryContext>(ref _blobHandleDatas, () => new BlobHandleDataQueryContext());
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
	public class OpaqueKeyValueDataQueryContext
	{
			public OpaqueKeyValueDataCollection Where(WhereDelegate<OpaqueKeyValueDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.OpaqueKeyValueData.Where(where, db);
			}
		   
			public OpaqueKeyValueDataCollection Where(WhereDelegate<OpaqueKeyValueDataColumns> where, OrderBy<OpaqueKeyValueDataColumns> orderBy = null, Database db = null)
			{
				return Bam.Blobs.Data.Dao.OpaqueKeyValueData.Where(where, orderBy, db);
			}

			public OpaqueKeyValueData OneWhere(WhereDelegate<OpaqueKeyValueDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.OpaqueKeyValueData.OneWhere(where, db);
			}

			public static OpaqueKeyValueData GetOneWhere(WhereDelegate<OpaqueKeyValueDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.OpaqueKeyValueData.GetOneWhere(where, db);
			}
		
			public OpaqueKeyValueData FirstOneWhere(WhereDelegate<OpaqueKeyValueDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.OpaqueKeyValueData.FirstOneWhere(where, db);
			}

			public OpaqueKeyValueDataCollection Top(int count, WhereDelegate<OpaqueKeyValueDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.OpaqueKeyValueData.Top(count, where, db);
			}

			public OpaqueKeyValueDataCollection Top(int count, WhereDelegate<OpaqueKeyValueDataColumns> where, OrderBy<OpaqueKeyValueDataColumns> orderBy, Database db = null)
			{
				return Bam.Blobs.Data.Dao.OpaqueKeyValueData.Top(count, where, orderBy, db);
			}

			public long Count(WhereDelegate<OpaqueKeyValueDataColumns> where, Database db = null)
			{
				return Bam.Blobs.Data.Dao.OpaqueKeyValueData.Count(where, db);
			}
	}

	static OpaqueKeyValueDataQueryContext _opaqueKeyValueDatas;
	static object _opaqueKeyValueDatasLock = new object();
	public static OpaqueKeyValueDataQueryContext OpaqueKeyValueDatas
	{
		get
		{
			return _opaqueKeyValueDatasLock.DoubleCheckLock<OpaqueKeyValueDataQueryContext>(ref _opaqueKeyValueDatas, () => new OpaqueKeyValueDataQueryContext());
		}
	}
    }
}																								
