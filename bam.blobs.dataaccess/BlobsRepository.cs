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
	public class BlobsRepository: DaoRepository
	{
		public BlobsRepository()
		{
			SchemaName = "Blobs";
			BaseNamespace = "Bam.Blobs.Data";			

			
			AddType<Bam.Blobs.Data.BlobChunkAssociationData>();
			
			
			AddType<Bam.Blobs.Data.BlobDescriptorData>();
			
			
			AddType<Bam.Blobs.Data.BlobPropertyData>();
			
			
			AddType<Bam.Blobs.Data.ChunkData>();
			

			DaoAssembly = typeof(BlobsRepository).Assembly;
		}

		object _addLock = new object();
        public override void AddType(Type type)
        {
            lock (_addLock)
            {
                base.AddType(type);
                DaoAssembly = typeof(BlobsRepository).Assembly;
            }
        }

		
		/// <summary>
		/// Set one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		public void SetOneBlobChunkAssociationDataWhere(WhereDelegate<BlobChunkAssociationDataColumns> where)
		{
			Bam.Blobs.Data.Dao.BlobChunkAssociationData.SetOneWhere(where, Database);
		}

		/// <summary>
		/// Set one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		public void SetOneBlobChunkAssociationDataWhere(WhereDelegate<BlobChunkAssociationDataColumns> where, out Bam.Blobs.Data.BlobChunkAssociationData result)
		{
			Bam.Blobs.Data.Dao.BlobChunkAssociationData.SetOneWhere(where, out Bam.Blobs.Data.Dao.BlobChunkAssociationData daoResult, Database);
			result = daoResult.CopyAs<Bam.Blobs.Data.BlobChunkAssociationData>();
		}

		/// <summary>
		/// Get one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		/// <param name="where"></param>
		public Bam.Blobs.Data.BlobChunkAssociationData GetOneBlobChunkAssociationDataWhere(WhereDelegate<BlobChunkAssociationDataColumns> where)
		{
			Type wrapperType = GetWrapperType<Bam.Blobs.Data.BlobChunkAssociationData>();
			return (Bam.Blobs.Data.BlobChunkAssociationData)Bam.Blobs.Data.Dao.BlobChunkAssociationData.GetOneWhere(where, Database)?.CopyAs(wrapperType, this);
		}

		/// <summary>
		/// Execute a query that should return only one result.  If no result is found null is returned.  If more
		/// than one result is returned a MultipleEntriesFoundException is thrown.  This method is most commonly used to retrieve a
		/// single BlobChunkAssociationData instance by its Id/Key value
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a BlobChunkAssociationDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobChunkAssociationDataColumns and other values
		/// </param>
		public Bam.Blobs.Data.BlobChunkAssociationData OneBlobChunkAssociationDataWhere(WhereDelegate<BlobChunkAssociationDataColumns> where)
        {
            Type wrapperType = GetWrapperType<Bam.Blobs.Data.BlobChunkAssociationData>();
            return (Bam.Blobs.Data.BlobChunkAssociationData)Bam.Blobs.Data.Dao.BlobChunkAssociationData.OneWhere(where, Database)?.CopyAs(wrapperType, this);
        }

		/// <summary>
		/// Execute a query and return the results. 
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a Bam.Blobs.Data.BlobChunkAssociationDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between Bam.Blobs.Data.BlobChunkAssociationDataColumns and other values
		/// </param>
		public IEnumerable<Bam.Blobs.Data.BlobChunkAssociationData> BlobChunkAssociationDatasWhere(WhereDelegate<BlobChunkAssociationDataColumns> where, OrderBy<BlobChunkAssociationDataColumns> orderBy = null)
        {
            return Wrap<Bam.Blobs.Data.BlobChunkAssociationData>(Bam.Blobs.Data.Dao.BlobChunkAssociationData.Where(where, orderBy, Database));
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
		/// <param name="where">A WhereDelegate that receives a BlobChunkAssociationDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobChunkAssociationDataColumns and other values
		/// </param>
		public IEnumerable<Bam.Blobs.Data.BlobChunkAssociationData> TopBlobChunkAssociationDatasWhere(int count, WhereDelegate<BlobChunkAssociationDataColumns> where)
        {
            return Wrap<Bam.Blobs.Data.BlobChunkAssociationData>(Bam.Blobs.Data.Dao.BlobChunkAssociationData.Top(count, where, Database));
        }

        public IEnumerable<Bam.Blobs.Data.BlobChunkAssociationData> TopBlobChunkAssociationDatasWhere(int count, WhereDelegate<BlobChunkAssociationDataColumns> where, OrderBy<BlobChunkAssociationDataColumns> orderBy)
        {
            return Wrap<Bam.Blobs.Data.BlobChunkAssociationData>(Bam.Blobs.Data.Dao.BlobChunkAssociationData.Top(count, where, orderBy, Database));
        }
                                
		/// <summary>
		/// Return the count of BlobChunkAssociationDatas
		/// </summary>
		public long CountBlobChunkAssociationDatas()
        {
            return Bam.Blobs.Data.Dao.BlobChunkAssociationData.Count(Database);
        }

		/// <summary>
		/// Execute a query and return the number of results
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a BlobChunkAssociationDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobChunkAssociationDataColumns and other values
		/// </param>
        public long CountBlobChunkAssociationDatasWhere(WhereDelegate<BlobChunkAssociationDataColumns> where)
        {
            return Bam.Blobs.Data.Dao.BlobChunkAssociationData.Count(where, Database);
        }
        
        /*public async Task BatchQueryBlobChunkAssociationDatas(int batchSize, WhereDelegate<BlobChunkAssociationDataColumns> where, Action<IEnumerable<Bam.Blobs.Data.BlobChunkAssociationData>> batchProcessor)
        {
            await Bam.Blobs.Data.Dao.BlobChunkAssociationData.BatchQuery(batchSize, where, (batch) =>
            {
				batchProcessor(Wrap<Bam.Blobs.Data.BlobChunkAssociationData>(batch));
            }, Database);
        }*/
		
        public async Task BatchAllBlobChunkAssociationDatas(int batchSize, Action<IEnumerable<Bam.Blobs.Data.BlobChunkAssociationData>> batchProcessor)
        {
            await Bam.Blobs.Data.Dao.BlobChunkAssociationData.BatchAll(batchSize, (batch) =>
            {
				batchProcessor(Wrap<Bam.Blobs.Data.BlobChunkAssociationData>(batch));
            }, Database);
        }

		
		/// <summary>
		/// Set one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		public void SetOneBlobDescriptorDataWhere(WhereDelegate<BlobDescriptorDataColumns> where)
		{
			Bam.Blobs.Data.Dao.BlobDescriptorData.SetOneWhere(where, Database);
		}

		/// <summary>
		/// Set one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		public void SetOneBlobDescriptorDataWhere(WhereDelegate<BlobDescriptorDataColumns> where, out Bam.Blobs.Data.BlobDescriptorData result)
		{
			Bam.Blobs.Data.Dao.BlobDescriptorData.SetOneWhere(where, out Bam.Blobs.Data.Dao.BlobDescriptorData daoResult, Database);
			result = daoResult.CopyAs<Bam.Blobs.Data.BlobDescriptorData>();
		}

		/// <summary>
		/// Get one entry matching the specified filter.  If none exists 
		/// one is created; success depends on the nullability
		/// of the specified columns.
		/// </summary>
		/// <param name="where"></param>
		public Bam.Blobs.Data.BlobDescriptorData GetOneBlobDescriptorDataWhere(WhereDelegate<BlobDescriptorDataColumns> where)
		{
			Type wrapperType = GetWrapperType<Bam.Blobs.Data.BlobDescriptorData>();
			return (Bam.Blobs.Data.BlobDescriptorData)Bam.Blobs.Data.Dao.BlobDescriptorData.GetOneWhere(where, Database)?.CopyAs(wrapperType, this);
		}

		/// <summary>
		/// Execute a query that should return only one result.  If no result is found null is returned.  If more
		/// than one result is returned a MultipleEntriesFoundException is thrown.  This method is most commonly used to retrieve a
		/// single BlobDescriptorData instance by its Id/Key value
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a BlobDescriptorDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobDescriptorDataColumns and other values
		/// </param>
		public Bam.Blobs.Data.BlobDescriptorData OneBlobDescriptorDataWhere(WhereDelegate<BlobDescriptorDataColumns> where)
        {
            Type wrapperType = GetWrapperType<Bam.Blobs.Data.BlobDescriptorData>();
            return (Bam.Blobs.Data.BlobDescriptorData)Bam.Blobs.Data.Dao.BlobDescriptorData.OneWhere(where, Database)?.CopyAs(wrapperType, this);
        }

		/// <summary>
		/// Execute a query and return the results. 
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a Bam.Blobs.Data.BlobDescriptorDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between Bam.Blobs.Data.BlobDescriptorDataColumns and other values
		/// </param>
		public IEnumerable<Bam.Blobs.Data.BlobDescriptorData> BlobDescriptorDatasWhere(WhereDelegate<BlobDescriptorDataColumns> where, OrderBy<BlobDescriptorDataColumns> orderBy = null)
        {
            return Wrap<Bam.Blobs.Data.BlobDescriptorData>(Bam.Blobs.Data.Dao.BlobDescriptorData.Where(where, orderBy, Database));
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
		/// <param name="where">A WhereDelegate that receives a BlobDescriptorDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobDescriptorDataColumns and other values
		/// </param>
		public IEnumerable<Bam.Blobs.Data.BlobDescriptorData> TopBlobDescriptorDatasWhere(int count, WhereDelegate<BlobDescriptorDataColumns> where)
        {
            return Wrap<Bam.Blobs.Data.BlobDescriptorData>(Bam.Blobs.Data.Dao.BlobDescriptorData.Top(count, where, Database));
        }

        public IEnumerable<Bam.Blobs.Data.BlobDescriptorData> TopBlobDescriptorDatasWhere(int count, WhereDelegate<BlobDescriptorDataColumns> where, OrderBy<BlobDescriptorDataColumns> orderBy)
        {
            return Wrap<Bam.Blobs.Data.BlobDescriptorData>(Bam.Blobs.Data.Dao.BlobDescriptorData.Top(count, where, orderBy, Database));
        }
                                
		/// <summary>
		/// Return the count of BlobDescriptorDatas
		/// </summary>
		public long CountBlobDescriptorDatas()
        {
            return Bam.Blobs.Data.Dao.BlobDescriptorData.Count(Database);
        }

		/// <summary>
		/// Execute a query and return the number of results
		/// </summary>
		/// <param name="where">A WhereDelegate that receives a BlobDescriptorDataColumns 
		/// and returns a IQueryFilter which is the result of any comparisons
		/// between BlobDescriptorDataColumns and other values
		/// </param>
        public long CountBlobDescriptorDatasWhere(WhereDelegate<BlobDescriptorDataColumns> where)
        {
            return Bam.Blobs.Data.Dao.BlobDescriptorData.Count(where, Database);
        }
        
        /*public async Task BatchQueryBlobDescriptorDatas(int batchSize, WhereDelegate<BlobDescriptorDataColumns> where, Action<IEnumerable<Bam.Blobs.Data.BlobDescriptorData>> batchProcessor)
        {
            await Bam.Blobs.Data.Dao.BlobDescriptorData.BatchQuery(batchSize, where, (batch) =>
            {
				batchProcessor(Wrap<Bam.Blobs.Data.BlobDescriptorData>(batch));
            }, Database);
        }*/
		
        public async Task BatchAllBlobDescriptorDatas(int batchSize, Action<IEnumerable<Bam.Blobs.Data.BlobDescriptorData>> batchProcessor)
        {
            await Bam.Blobs.Data.Dao.BlobDescriptorData.BatchAll(batchSize, (batch) =>
            {
				batchProcessor(Wrap<Bam.Blobs.Data.BlobDescriptorData>(batch));
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


	}
}																								
