/*
This file was generated and should not be modified directly
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Bam;
using Bam.Data;
using Bam.Data.Repositories;
using Bam.Blobs.Data;

namespace Bam.Blobs.Data.Dao.Repository
{
	[Serializable]
	public class BlobDataRepository: DaoRepository
	{
		public BlobDataRepository()
		{
			SchemaName = "BlobData";
			BaseNamespace = "Bam.Blobs.Data";

			
			AddType<Bam.Blobs.Data.BlobChunkData>();
			
			
			AddType<Bam.Blobs.Data.BlobHandleData>();
			
			
			AddType<Bam.Blobs.Data.BlobPropertyData>();
			
			
			AddType<Bam.Blobs.Data.ChunkData>();
			
			
			AddType<Bam.Blobs.Data.OpaqueKeyValueData>();
			

			DaoAssembly = typeof(BlobDataRepository).Assembly;
		}

		object _addLock = new object();
        public override void AddType(Type type)
        {
            lock (_addLock)
            {
                base.AddType(type);
                DaoAssembly = typeof(BlobDataRepository).Assembly;
            }
        }

		
		/// <summary>
		/// Set one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		public void SetOneBlobChunkDataWhere(WhereDelegate<BlobChunkDataColumns> where)
		{
			Bam.Blobs.Data.Dao.BlobChunkData.SetOneWhere(where, Database);
		}

		/// <summary>
		/// Set one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		public void SetOneBlobChunkDataWhere(WhereDelegate<BlobChunkDataColumns> where, out Bam.Blobs.Data.BlobChunkData result)
		{
			Bam.Blobs.Data.Dao.BlobChunkData.SetOneWhere(where, out Bam.Blobs.Data.Dao.BlobChunkData daoResult, Database);
			result = daoResult.CopyAs<Bam.Blobs.Data.BlobChunkData>();
		}

		/// <summary>
		/// Get one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		/// <param name="where"></param>
		public Bam.Blobs.Data.BlobChunkData GetOneBlobChunkDataWhere(WhereDelegate<BlobChunkDataColumns> where)
		{
			Type wrapperType = GetWrapperType<Bam.Blobs.Data.BlobChunkData>();
			return (Bam.Blobs.Data.BlobChunkData)Bam.Blobs.Data.Dao.BlobChunkData.GetOneWhere(where, Database)?.CopyAs(wrapperType, this);
		}

		/// <summary>
		/// Execute a query that should return only one result.  If no result is found null is returned.  If more
		/// than one result is returned a MultipleEntriesFoundException is thrown.  This method is most commonly used to retrieve a
		/// single BlobChunkData instance by its Id/Key value
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a BlobChunkDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobChunkDataColumns and other values
		/// </param>
		public Bam.Blobs.Data.BlobChunkData OneBlobChunkDataWhere(WhereDelegate<BlobChunkDataColumns> where)
        {
            Type wrapperType = GetWrapperType<Bam.Blobs.Data.BlobChunkData>();
            return (Bam.Blobs.Data.BlobChunkData)Bam.Blobs.Data.Dao.BlobChunkData.OneWhere(where, Database)?.CopyAs(wrapperType, this);
        }

		/// <summary>
		/// Execute a query and return the results. 
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a Bam.Blobs.Data.BlobChunkDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between Bam.Blobs.Data.BlobChunkDataColumns and other values
		/// </param>
		public IEnumerable<Bam.Blobs.Data.BlobChunkData> BlobChunkDatasWhere(WhereDelegate<BlobChunkDataColumns> where, OrderBy<BlobChunkDataColumns> orderBy = null)
        {
            return Wrap<Bam.Blobs.Data.BlobChunkData>(Bam.Blobs.Data.Dao.BlobChunkData.Where(where, orderBy, Database));
        }
		
		/// <summary>
		/// Execute a query and return the specified number
		/// of values. This method issues a sql TOP clause so only the 
		/// specified number of values will be returned.
		/// </summary>
		/// <param name="count">The number of values to return.
		/// This value is used in the sql query so no more than this 
		/// number of values will be returned by the database.
		/// </param>
		/// <param name="where">A WhereDelegate that receives a BlobChunkDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobChunkDataColumns and other values
		/// </param>
		public IEnumerable<Bam.Blobs.Data.BlobChunkData> TopBlobChunkDatasWhere(int count, WhereDelegate<BlobChunkDataColumns> where)
        {
            return Wrap<Bam.Blobs.Data.BlobChunkData>(Bam.Blobs.Data.Dao.BlobChunkData.Top(count, where, Database));
        }

        public IEnumerable<Bam.Blobs.Data.BlobChunkData> TopBlobChunkDatasWhere(int count, WhereDelegate<BlobChunkDataColumns> where, OrderBy<BlobChunkDataColumns> orderBy)
        {
            return Wrap<Bam.Blobs.Data.BlobChunkData>(Bam.Blobs.Data.Dao.BlobChunkData.Top(count, where, orderBy, Database));
        }
                                
		/// <summary>
		/// Return the count of BlobChunkDatas
		/// </summary>
		public long CountBlobChunkDatas()
        {
            return Bam.Blobs.Data.Dao.BlobChunkData.Count(Database);
        }

		/// <summary>
		/// Execute a query and return the number of results
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a BlobChunkDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobChunkDataColumns and other values
		/// </param>
        public long CountBlobChunkDatasWhere(WhereDelegate<BlobChunkDataColumns> where)
        {
            return Bam.Blobs.Data.Dao.BlobChunkData.Count(where, Database);
        }
        
        /*public async Task BatchQueryBlobChunkDatas(int batchSize, WhereDelegate<BlobChunkDataColumns> where, Action<IEnumerable<Bam.Blobs.Data.BlobChunkData>> batchProcessor)
        {
            await Bam.Blobs.Data.Dao.BlobChunkData.BatchQuery(batchSize, where, (batch) =>
            {
				batchProcessor(Wrap<Bam.Blobs.Data.BlobChunkData>(batch));
            }, Database);
        }*/
		
        public async Task BatchAllBlobChunkDatas(int batchSize, Action<IEnumerable<Bam.Blobs.Data.BlobChunkData>> batchProcessor)
        {
            await Bam.Blobs.Data.Dao.BlobChunkData.BatchAll(batchSize, (batch) =>
            {
				batchProcessor(Wrap<Bam.Blobs.Data.BlobChunkData>(batch));
            }, Database);
        }

		
		/// <summary>
		/// Set one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		public void SetOneBlobHandleDataWhere(WhereDelegate<BlobHandleDataColumns> where)
		{
			Bam.Blobs.Data.Dao.BlobHandleData.SetOneWhere(where, Database);
		}

		/// <summary>
		/// Set one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		public void SetOneBlobHandleDataWhere(WhereDelegate<BlobHandleDataColumns> where, out Bam.Blobs.Data.BlobHandleData result)
		{
			Bam.Blobs.Data.Dao.BlobHandleData.SetOneWhere(where, out Bam.Blobs.Data.Dao.BlobHandleData daoResult, Database);
			result = daoResult.CopyAs<Bam.Blobs.Data.BlobHandleData>();
		}

		/// <summary>
		/// Get one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		/// <param name="where"></param>
		public Bam.Blobs.Data.BlobHandleData GetOneBlobHandleDataWhere(WhereDelegate<BlobHandleDataColumns> where)
		{
			Type wrapperType = GetWrapperType<Bam.Blobs.Data.BlobHandleData>();
			return (Bam.Blobs.Data.BlobHandleData)Bam.Blobs.Data.Dao.BlobHandleData.GetOneWhere(where, Database)?.CopyAs(wrapperType, this);
		}

		/// <summary>
		/// Execute a query that should return only one result.  If no result is found null is returned.  If more
		/// than one result is returned a MultipleEntriesFoundException is thrown.  This method is most commonly used to retrieve a
		/// single BlobHandleData instance by its Id/Key value
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a BlobHandleDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobHandleDataColumns and other values
		/// </param>
		public Bam.Blobs.Data.BlobHandleData OneBlobHandleDataWhere(WhereDelegate<BlobHandleDataColumns> where)
        {
            Type wrapperType = GetWrapperType<Bam.Blobs.Data.BlobHandleData>();
            return (Bam.Blobs.Data.BlobHandleData)Bam.Blobs.Data.Dao.BlobHandleData.OneWhere(where, Database)?.CopyAs(wrapperType, this);
        }

		/// <summary>
		/// Execute a query and return the results. 
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a Bam.Blobs.Data.BlobHandleDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between Bam.Blobs.Data.BlobHandleDataColumns and other values
		/// </param>
		public IEnumerable<Bam.Blobs.Data.BlobHandleData> BlobHandleDatasWhere(WhereDelegate<BlobHandleDataColumns> where, OrderBy<BlobHandleDataColumns> orderBy = null)
        {
            return Wrap<Bam.Blobs.Data.BlobHandleData>(Bam.Blobs.Data.Dao.BlobHandleData.Where(where, orderBy, Database));
        }
		
		/// <summary>
		/// Execute a query and return the specified number
		/// of values. This method issues a sql TOP clause so only the 
		/// specified number of values will be returned.
		/// </summary>
		/// <param name="count">The number of values to return.
		/// This value is used in the sql query so no more than this 
		/// number of values will be returned by the database.
		/// </param>
		/// <param name="where">A WhereDelegate that receives a BlobHandleDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobHandleDataColumns and other values
		/// </param>
		public IEnumerable<Bam.Blobs.Data.BlobHandleData> TopBlobHandleDatasWhere(int count, WhereDelegate<BlobHandleDataColumns> where)
        {
            return Wrap<Bam.Blobs.Data.BlobHandleData>(Bam.Blobs.Data.Dao.BlobHandleData.Top(count, where, Database));
        }

        public IEnumerable<Bam.Blobs.Data.BlobHandleData> TopBlobHandleDatasWhere(int count, WhereDelegate<BlobHandleDataColumns> where, OrderBy<BlobHandleDataColumns> orderBy)
        {
            return Wrap<Bam.Blobs.Data.BlobHandleData>(Bam.Blobs.Data.Dao.BlobHandleData.Top(count, where, orderBy, Database));
        }
                                
		/// <summary>
		/// Return the count of BlobHandleDatas
		/// </summary>
		public long CountBlobHandleDatas()
        {
            return Bam.Blobs.Data.Dao.BlobHandleData.Count(Database);
        }

		/// <summary>
		/// Execute a query and return the number of results
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a BlobHandleDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobHandleDataColumns and other values
		/// </param>
        public long CountBlobHandleDatasWhere(WhereDelegate<BlobHandleDataColumns> where)
        {
            return Bam.Blobs.Data.Dao.BlobHandleData.Count(where, Database);
        }
        
        /*public async Task BatchQueryBlobHandleDatas(int batchSize, WhereDelegate<BlobHandleDataColumns> where, Action<IEnumerable<Bam.Blobs.Data.BlobHandleData>> batchProcessor)
        {
            await Bam.Blobs.Data.Dao.BlobHandleData.BatchQuery(batchSize, where, (batch) =>
            {
				batchProcessor(Wrap<Bam.Blobs.Data.BlobHandleData>(batch));
            }, Database);
        }*/
		
        public async Task BatchAllBlobHandleDatas(int batchSize, Action<IEnumerable<Bam.Blobs.Data.BlobHandleData>> batchProcessor)
        {
            await Bam.Blobs.Data.Dao.BlobHandleData.BatchAll(batchSize, (batch) =>
            {
				batchProcessor(Wrap<Bam.Blobs.Data.BlobHandleData>(batch));
            }, Database);
        }

		
		/// <summary>
		/// Set one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		public void SetOneBlobPropertyDataWhere(WhereDelegate<BlobPropertyDataColumns> where)
		{
			Bam.Blobs.Data.Dao.BlobPropertyData.SetOneWhere(where, Database);
		}

		/// <summary>
		/// Set one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		public void SetOneBlobPropertyDataWhere(WhereDelegate<BlobPropertyDataColumns> where, out Bam.Blobs.Data.BlobPropertyData result)
		{
			Bam.Blobs.Data.Dao.BlobPropertyData.SetOneWhere(where, out Bam.Blobs.Data.Dao.BlobPropertyData daoResult, Database);
			result = daoResult.CopyAs<Bam.Blobs.Data.BlobPropertyData>();
		}

		/// <summary>
		/// Get one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		/// <param name="where"></param>
		public Bam.Blobs.Data.BlobPropertyData GetOneBlobPropertyDataWhere(WhereDelegate<BlobPropertyDataColumns> where)
		{
			Type wrapperType = GetWrapperType<Bam.Blobs.Data.BlobPropertyData>();
			return (Bam.Blobs.Data.BlobPropertyData)Bam.Blobs.Data.Dao.BlobPropertyData.GetOneWhere(where, Database)?.CopyAs(wrapperType, this);
		}

		/// <summary>
		/// Execute a query that should return only one result.  If no result is found null is returned.  If more
		/// than one result is returned a MultipleEntriesFoundException is thrown.  This method is most commonly used to retrieve a
		/// single BlobPropertyData instance by its Id/Key value
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a BlobPropertyDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobPropertyDataColumns and other values
		/// </param>
		public Bam.Blobs.Data.BlobPropertyData OneBlobPropertyDataWhere(WhereDelegate<BlobPropertyDataColumns> where)
        {
            Type wrapperType = GetWrapperType<Bam.Blobs.Data.BlobPropertyData>();
            return (Bam.Blobs.Data.BlobPropertyData)Bam.Blobs.Data.Dao.BlobPropertyData.OneWhere(where, Database)?.CopyAs(wrapperType, this);
        }

		/// <summary>
		/// Execute a query and return the results. 
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a Bam.Blobs.Data.BlobPropertyDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between Bam.Blobs.Data.BlobPropertyDataColumns and other values
		/// </param>
		public IEnumerable<Bam.Blobs.Data.BlobPropertyData> BlobPropertyDatasWhere(WhereDelegate<BlobPropertyDataColumns> where, OrderBy<BlobPropertyDataColumns> orderBy = null)
        {
            return Wrap<Bam.Blobs.Data.BlobPropertyData>(Bam.Blobs.Data.Dao.BlobPropertyData.Where(where, orderBy, Database));
        }
		
		/// <summary>
		/// Execute a query and return the specified number
		/// of values. This method issues a sql TOP clause so only the 
		/// specified number of values will be returned.
		/// </summary>
		/// <param name="count">The number of values to return.
		/// This value is used in the sql query so no more than this 
		/// number of values will be returned by the database.
		/// </param>
		/// <param name="where">A WhereDelegate that receives a BlobPropertyDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobPropertyDataColumns and other values
		/// </param>
		public IEnumerable<Bam.Blobs.Data.BlobPropertyData> TopBlobPropertyDatasWhere(int count, WhereDelegate<BlobPropertyDataColumns> where)
        {
            return Wrap<Bam.Blobs.Data.BlobPropertyData>(Bam.Blobs.Data.Dao.BlobPropertyData.Top(count, where, Database));
        }

        public IEnumerable<Bam.Blobs.Data.BlobPropertyData> TopBlobPropertyDatasWhere(int count, WhereDelegate<BlobPropertyDataColumns> where, OrderBy<BlobPropertyDataColumns> orderBy)
        {
            return Wrap<Bam.Blobs.Data.BlobPropertyData>(Bam.Blobs.Data.Dao.BlobPropertyData.Top(count, where, orderBy, Database));
        }
                                
		/// <summary>
		/// Return the count of BlobPropertyDatas
		/// </summary>
		public long CountBlobPropertyDatas()
        {
            return Bam.Blobs.Data.Dao.BlobPropertyData.Count(Database);
        }

		/// <summary>
		/// Execute a query and return the number of results
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a BlobPropertyDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobPropertyDataColumns and other values
		/// </param>
        public long CountBlobPropertyDatasWhere(WhereDelegate<BlobPropertyDataColumns> where)
        {
            return Bam.Blobs.Data.Dao.BlobPropertyData.Count(where, Database);
        }
        
        /*public async Task BatchQueryBlobPropertyDatas(int batchSize, WhereDelegate<BlobPropertyDataColumns> where, Action<IEnumerable<Bam.Blobs.Data.BlobPropertyData>> batchProcessor)
        {
            await Bam.Blobs.Data.Dao.BlobPropertyData.BatchQuery(batchSize, where, (batch) =>
            {
				batchProcessor(Wrap<Bam.Blobs.Data.BlobPropertyData>(batch));
            }, Database);
        }*/
		
        public async Task BatchAllBlobPropertyDatas(int batchSize, Action<IEnumerable<Bam.Blobs.Data.BlobPropertyData>> batchProcessor)
        {
            await Bam.Blobs.Data.Dao.BlobPropertyData.BatchAll(batchSize, (batch) =>
            {
				batchProcessor(Wrap<Bam.Blobs.Data.BlobPropertyData>(batch));
            }, Database);
        }

		
		/// <summary>
		/// Set one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		public void SetOneChunkDataWhere(WhereDelegate<ChunkDataColumns> where)
		{
			Bam.Blobs.Data.Dao.ChunkData.SetOneWhere(where, Database);
		}

		/// <summary>
		/// Set one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		public void SetOneChunkDataWhere(WhereDelegate<ChunkDataColumns> where, out Bam.Blobs.Data.ChunkData result)
		{
			Bam.Blobs.Data.Dao.ChunkData.SetOneWhere(where, out Bam.Blobs.Data.Dao.ChunkData daoResult, Database);
			result = daoResult.CopyAs<Bam.Blobs.Data.ChunkData>();
		}

		/// <summary>
		/// Get one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		/// <param name="where"></param>
		public Bam.Blobs.Data.ChunkData GetOneChunkDataWhere(WhereDelegate<ChunkDataColumns> where)
		{
			Type wrapperType = GetWrapperType<Bam.Blobs.Data.ChunkData>();
			return (Bam.Blobs.Data.ChunkData)Bam.Blobs.Data.Dao.ChunkData.GetOneWhere(where, Database)?.CopyAs(wrapperType, this);
		}

		/// <summary>
		/// Execute a query that should return only one result.  If no result is found null is returned.  If more
		/// than one result is returned a MultipleEntriesFoundException is thrown.  This method is most commonly used to retrieve a
		/// single ChunkData instance by its Id/Key value
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a ChunkDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between ChunkDataColumns and other values
		/// </param>
		public Bam.Blobs.Data.ChunkData OneChunkDataWhere(WhereDelegate<ChunkDataColumns> where)
        {
            Type wrapperType = GetWrapperType<Bam.Blobs.Data.ChunkData>();
            return (Bam.Blobs.Data.ChunkData)Bam.Blobs.Data.Dao.ChunkData.OneWhere(where, Database)?.CopyAs(wrapperType, this);
        }

		/// <summary>
		/// Execute a query and return the results. 
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a Bam.Blobs.Data.ChunkDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between Bam.Blobs.Data.ChunkDataColumns and other values
		/// </param>
		public IEnumerable<Bam.Blobs.Data.ChunkData> ChunkDatasWhere(WhereDelegate<ChunkDataColumns> where, OrderBy<ChunkDataColumns> orderBy = null)
        {
            return Wrap<Bam.Blobs.Data.ChunkData>(Bam.Blobs.Data.Dao.ChunkData.Where(where, orderBy, Database));
        }
		
		/// <summary>
		/// Execute a query and return the specified number
		/// of values. This method issues a sql TOP clause so only the 
		/// specified number of values will be returned.
		/// </summary>
		/// <param name="count">The number of values to return.
		/// This value is used in the sql query so no more than this 
		/// number of values will be returned by the database.
		/// </param>
		/// <param name="where">A WhereDelegate that receives a ChunkDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between ChunkDataColumns and other values
		/// </param>
		public IEnumerable<Bam.Blobs.Data.ChunkData> TopChunkDatasWhere(int count, WhereDelegate<ChunkDataColumns> where)
        {
            return Wrap<Bam.Blobs.Data.ChunkData>(Bam.Blobs.Data.Dao.ChunkData.Top(count, where, Database));
        }

        public IEnumerable<Bam.Blobs.Data.ChunkData> TopChunkDatasWhere(int count, WhereDelegate<ChunkDataColumns> where, OrderBy<ChunkDataColumns> orderBy)
        {
            return Wrap<Bam.Blobs.Data.ChunkData>(Bam.Blobs.Data.Dao.ChunkData.Top(count, where, orderBy, Database));
        }
                                
		/// <summary>
		/// Return the count of ChunkDatas
		/// </summary>
		public long CountChunkDatas()
        {
            return Bam.Blobs.Data.Dao.ChunkData.Count(Database);
        }

		/// <summary>
		/// Execute a query and return the number of results
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a ChunkDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between ChunkDataColumns and other values
		/// </param>
        public long CountChunkDatasWhere(WhereDelegate<ChunkDataColumns> where)
        {
            return Bam.Blobs.Data.Dao.ChunkData.Count(where, Database);
        }
        
        /*public async Task BatchQueryChunkDatas(int batchSize, WhereDelegate<ChunkDataColumns> where, Action<IEnumerable<Bam.Blobs.Data.ChunkData>> batchProcessor)
        {
            await Bam.Blobs.Data.Dao.ChunkData.BatchQuery(batchSize, where, (batch) =>
            {
				batchProcessor(Wrap<Bam.Blobs.Data.ChunkData>(batch));
            }, Database);
        }*/
		
        public async Task BatchAllChunkDatas(int batchSize, Action<IEnumerable<Bam.Blobs.Data.ChunkData>> batchProcessor)
        {
            await Bam.Blobs.Data.Dao.ChunkData.BatchAll(batchSize, (batch) =>
            {
				batchProcessor(Wrap<Bam.Blobs.Data.ChunkData>(batch));
            }, Database);
        }

		
		/// <summary>
		/// Set one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		public void SetOneOpaqueKeyValueDataWhere(WhereDelegate<OpaqueKeyValueDataColumns> where)
		{
			Bam.Blobs.Data.Dao.OpaqueKeyValueData.SetOneWhere(where, Database);
		}

		/// <summary>
		/// Set one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		public void SetOneOpaqueKeyValueDataWhere(WhereDelegate<OpaqueKeyValueDataColumns> where, out Bam.Blobs.Data.OpaqueKeyValueData result)
		{
			Bam.Blobs.Data.Dao.OpaqueKeyValueData.SetOneWhere(where, out Bam.Blobs.Data.Dao.OpaqueKeyValueData daoResult, Database);
			result = daoResult.CopyAs<Bam.Blobs.Data.OpaqueKeyValueData>();
		}

		/// <summary>
		/// Get one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		/// <param name="where"></param>
		public Bam.Blobs.Data.OpaqueKeyValueData GetOneOpaqueKeyValueDataWhere(WhereDelegate<OpaqueKeyValueDataColumns> where)
		{
			Type wrapperType = GetWrapperType<Bam.Blobs.Data.OpaqueKeyValueData>();
			return (Bam.Blobs.Data.OpaqueKeyValueData)Bam.Blobs.Data.Dao.OpaqueKeyValueData.GetOneWhere(where, Database)?.CopyAs(wrapperType, this);
		}

		/// <summary>
		/// Execute a query that should return only one result.  If no result is found null is returned.  If more
		/// than one result is returned a MultipleEntriesFoundException is thrown.  This method is most commonly used to retrieve a
		/// single OpaqueKeyValueData instance by its Id/Key value
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a OpaqueKeyValueDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between OpaqueKeyValueDataColumns and other values
		/// </param>
		public Bam.Blobs.Data.OpaqueKeyValueData OneOpaqueKeyValueDataWhere(WhereDelegate<OpaqueKeyValueDataColumns> where)
        {
            Type wrapperType = GetWrapperType<Bam.Blobs.Data.OpaqueKeyValueData>();
            return (Bam.Blobs.Data.OpaqueKeyValueData)Bam.Blobs.Data.Dao.OpaqueKeyValueData.OneWhere(where, Database)?.CopyAs(wrapperType, this);
        }

		/// <summary>
		/// Execute a query and return the results. 
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a Bam.Blobs.Data.OpaqueKeyValueDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between Bam.Blobs.Data.OpaqueKeyValueDataColumns and other values
		/// </param>
		public IEnumerable<Bam.Blobs.Data.OpaqueKeyValueData> OpaqueKeyValueDatasWhere(WhereDelegate<OpaqueKeyValueDataColumns> where, OrderBy<OpaqueKeyValueDataColumns> orderBy = null)
        {
            return Wrap<Bam.Blobs.Data.OpaqueKeyValueData>(Bam.Blobs.Data.Dao.OpaqueKeyValueData.Where(where, orderBy, Database));
        }
		
		/// <summary>
		/// Execute a query and return the specified number
		/// of values. This method issues a sql TOP clause so only the 
		/// specified number of values will be returned.
		/// </summary>
		/// <param name="count">The number of values to return.
		/// This value is used in the sql query so no more than this 
		/// number of values will be returned by the database.
		/// </param>
		/// <param name="where">A WhereDelegate that receives a OpaqueKeyValueDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between OpaqueKeyValueDataColumns and other values
		/// </param>
		public IEnumerable<Bam.Blobs.Data.OpaqueKeyValueData> TopOpaqueKeyValueDatasWhere(int count, WhereDelegate<OpaqueKeyValueDataColumns> where)
        {
            return Wrap<Bam.Blobs.Data.OpaqueKeyValueData>(Bam.Blobs.Data.Dao.OpaqueKeyValueData.Top(count, where, Database));
        }

        public IEnumerable<Bam.Blobs.Data.OpaqueKeyValueData> TopOpaqueKeyValueDatasWhere(int count, WhereDelegate<OpaqueKeyValueDataColumns> where, OrderBy<OpaqueKeyValueDataColumns> orderBy)
        {
            return Wrap<Bam.Blobs.Data.OpaqueKeyValueData>(Bam.Blobs.Data.Dao.OpaqueKeyValueData.Top(count, where, orderBy, Database));
        }
                                
		/// <summary>
		/// Return the count of OpaqueKeyValueDatas
		/// </summary>
		public long CountOpaqueKeyValueDatas()
        {
            return Bam.Blobs.Data.Dao.OpaqueKeyValueData.Count(Database);
        }

		/// <summary>
		/// Execute a query and return the number of results
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a OpaqueKeyValueDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between OpaqueKeyValueDataColumns and other values
		/// </param>
        public long CountOpaqueKeyValueDatasWhere(WhereDelegate<OpaqueKeyValueDataColumns> where)
        {
            return Bam.Blobs.Data.Dao.OpaqueKeyValueData.Count(where, Database);
        }
        
        /*public async Task BatchQueryOpaqueKeyValueDatas(int batchSize, WhereDelegate<OpaqueKeyValueDataColumns> where, Action<IEnumerable<Bam.Blobs.Data.OpaqueKeyValueData>> batchProcessor)
        {
            await Bam.Blobs.Data.Dao.OpaqueKeyValueData.BatchQuery(batchSize, where, (batch) =>
            {
				batchProcessor(Wrap<Bam.Blobs.Data.OpaqueKeyValueData>(batch));
            }, Database);
        }*/
		
        public async Task BatchAllOpaqueKeyValueDatas(int batchSize, Action<IEnumerable<Bam.Blobs.Data.OpaqueKeyValueData>> batchProcessor)
        {
            await Bam.Blobs.Data.Dao.OpaqueKeyValueData.BatchAll(batchSize, (batch) =>
            {
				batchProcessor(Wrap<Bam.Blobs.Data.OpaqueKeyValueData>(batch));
            }, Database);
        }


	}
}																								
