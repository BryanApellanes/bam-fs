using Bam.Net.CoreServices.Files;
using Bam.Blobs.Data;
using Bam.Data;
using Bam.Data.Repositories;
using Bam.Generators;
using Bam.Logging;

namespace Bam.Blobs
{
    /// <summary>
    /// An IChunkStorage implementation that stores chunk data in an IRepository.
    /// </summary>
    /// <seealso cref="Bam.Net.CoreServices.Files.IChunkStorage" />
    public class RepositoryChunkStorage: IChunkStorage
    {
        public RepositoryChunkStorage()
        {
        }

        public RepositoryChunkStorage(IDataDirectoryProvider dataProvider, ILogger logger = null)
        {
            DataProvider = dataProvider;
            Repository = new DefaultDaoRepository();
            Repository.AddType<ChunkData>();
        }

        public RepositoryChunkStorage(IRepository repository, IDataDirectoryProvider dataSettings, ILogger logger = null):this(dataSettings, logger)
        {
            Repository = repository;
        }

        public IDataDirectoryProvider DataProvider { get; set; }
        public IRepository Repository { get; set; }

        public IChunk? GetChunk(string hash)
        {
            ChunkData? data = Repository.Query(nameof(ChunkData.ChunkHash), hash).CopyAs<ChunkData>().FirstOrDefault();
            return data?.ToChunk();
        }

        public void SetChunk(IChunk chunk)
        {
            Args.ThrowIf(!chunk.ChunkHash.Equals(chunk.Data.Sha256()), "Hash validation failed");
            Task.Run(() =>
            {
                ChunkData? existingChunk = Repository.Query<ChunkData>(Filter.Where(nameof(ChunkData.ChunkHash)) == chunk.ChunkHash).FirstOrDefault();
                if (existingChunk == null || !existingChunk.Data.FromBase64().Sha256().Equals(chunk.Data.Sha256()))
                {
                    Repository.Save(ChunkData.FromChunk(chunk));
                }
            });         
        }
    }
}
