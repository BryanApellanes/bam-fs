using Bam.Blobs.Data;
using Bam.Data;
using Bam.Data.Repositories;
using Bam.Logging;
using Bam.Net.CoreServices.Files;

namespace Bam.Blobs
{
    public class FileService : IFileService
    {
        protected FileService() { }
        public FileService(IRepository repository, IDataDirectoryProvider dataProvider, ILogger logger = null)
        {
            Repository = repository;
            Repository.AddTypes(new Type[]
            {
                typeof(BlobDescriptorData),
                typeof(BlobChunkAssociationData),
                typeof(ChunkData)
            });
            DataProvider = dataProvider;
            Logger = logger ?? Log.Default;
            FileSystemChunkStorage = new FileSystemChunkStorage(DataProvider, Logger);
            RepositoryChunkStorage = new RepositoryChunkStorage(Repository, DataProvider, Logger);
            ChunkStorage = new CompositeChunkStorage();
            ChunkStorage.AddStorage(FileSystemChunkStorage);
            ChunkStorage.AddStorage(RepositoryChunkStorage);

            ChunkDataBatchSize = 10;
            ChunkLength = 256000;
            ChunkDirectory = DataProvider.GetChunksDirectory().FullName;
            SetChunkDataDescriptorRetriever();
        }

        public IRepository Repository { get; set; }
        public ILogger? Logger { get; set; }
        
        public FileService AddStorage(IChunkStorage storage)
        {
            ChunkStorage.AddStorage(storage);
            return this;
        }

        public FileService ClearStorage()
        {
            ChunkStorage.ClearStorage();
            return this;
        }
        
        public Func<string, int, int, IEnumerable<BlobChunkAssociationData>> ChunkDataDescriptorRetriever;
        public string ChunkDirectory { get; internal set; }
        public int ChunkDataBatchSize { get; internal set; }
        public int ChunkLength { get; internal set; }
        protected CompositeChunkStorage ChunkStorage { get; set; }
        protected FileSystemChunkStorage FileSystemChunkStorage { get; set; }
        protected RepositoryChunkStorage RepositoryChunkStorage { get; set; }
        public virtual BlobChunkAssociationData SaveChunkDataDescriptor(BlobChunkAssociationData xref)
        {
            BlobChunkAssociationData? existingXref = Repository
                               .Query<BlobChunkAssociationData>(
                                       Filter.Where(nameof(BlobChunkAssociationData.BlobHash)) == xref.BlobHash &&
                                       Filter.Where(nameof(BlobChunkAssociationData.ChunkHash)) == xref.ChunkHash &&
                                       Filter.Where(nameof(BlobChunkAssociationData.ChunkIndex)) == xref.ChunkIndex)
                                   .FirstOrDefault();
            if (existingXref == null)
            {
                existingXref = Repository.Save(xref);
            }
            return existingXref;
        }

        /// <summary>
        /// Save the ChunkData
        /// </summary>
        /// <param name="chunk"></param>
        /// <returns></returns>
        public virtual void SaveChunkData(ChunkData chunk)
        {
            Args.ThrowIf(!chunk.ChunkHash.Equals(chunk.Data.FromBase64().Sha256()), "Hash validation failed");
            ChunkStorage.SetChunk(chunk.ToChunk());
        }

        /// <summary>
        /// Retrieves the specified chunkdata from the 
        /// file system if its there otherwise from the repository
        /// </summary>
        /// <param name="chunkHash"></param>
        /// <returns></returns>
        public virtual ChunkData GetChunkData(string chunkHash)
        {
            return ChunkData.FromChunk(ChunkStorage.GetChunk(chunkHash));
        }

        public virtual ChunkedFileDescriptor GetFileDescriptor(string fileHashOrName)
        {
            ChunkedFileDescriptor descriptor = GetFileDescriptorByFileHash(fileHashOrName);
            if (descriptor == null)
            {
                descriptor = GetFileDescriptorsByFileName(fileHashOrName).SingleOrDefault();
            }
            return descriptor;
        }

        public virtual ChunkedFileDescriptor GetFileDescriptorByFileHash(string fileHash)
        {
            return Repository.Query<ChunkedFileDescriptor>(Filter.Where(nameof(ChunkedFileDescriptor.FileHash)) == fileHash).SingleOrDefault();
        }

        public virtual IEnumerable<ChunkedFileDescriptor> GetFileDescriptorsByFileName(string fileName, string originalDirectory = null)
        {
            QueryFilter filter = Filter.Where(nameof(ChunkedFileDescriptor.FileName)) == fileName;
            if (!string.IsNullOrEmpty(originalDirectory))
            {
                filter = filter && Filter.Where(nameof(ChunkedFileDescriptor.OriginalDirectory)) == originalDirectory;
            }
            return Repository.Query<ChunkedFileDescriptor>(filter);
        }

        /// <summary>
        /// Get a set of FileChunks for the specified fileHash
        /// starting from the specified fromIndex returning
        /// the specified batchSize number of FileChunks
        /// </summary>
        /// <param name="fileHash">The hash of the file to get chunks for</param>
        /// <param name="fromIndex">The exclusive chunk index to start from</param>
        /// <param name="batchSize">The number of chunks to return</param>
        /// <returns></returns>
        public virtual List<FileChunk> GetFileChunks(string fileHash, int fromIndex, int batchSize)
        {
            List<FileChunk> chunks = YieldFileChunks(fileHash, fromIndex, batchSize).ToList();
            chunks.Sort((x, y) => x.ChunkIndex.CompareTo(y.ChunkIndex));
            return chunks;
        }

        [Local]
        public IEnumerable<FileChunk> YieldFileChunks(string fileHash, int fromIndex, int batchSize)
        {
            IEnumerable<ChunkDataDescriptor> xrefs = ChunkDataDescriptorRetriever(fileHash, fromIndex, batchSize);
            foreach (ChunkDataDescriptor xref in xrefs)
            {
                ChunkData data = GetChunkData(xref.ChunkHash);
                yield return new FileChunk
                {
                    FileHash = xref.FileHash,
                    ChunkHash = xref.ChunkHash,
                    ChunkIndex = xref.ChunkIndex,
                    StreamIndex = xref.StreamIndex,
                    ChunkLength = data.ChunkLength,
                    Data = data.Data
                };
            }
        }

        public IEnumerable<ChunkedFileDescriptor> ListFiles(string originalDirectory)
        {
            return Repository.Query<ChunkedFileDescriptor>(Filter.Where(nameof(ChunkedFileDescriptor.OriginalDirectory)) == originalDirectory);
        }

        [Exclude]
        public ChunkedFileWriter GetFileWriter(string fileHash)
        {
            return ChunkedFileWriter.FromFileHash(this, fileHash, Logger);
        }

        public virtual ChunkData GetChunkDataFromRepository(string chunkHash)
        {
            ChunkData result = Repository.Query<ChunkData>(Filter.Where(nameof(ChunkData.ChunkHash)) == chunkHash).FirstOrDefault();
            Args.ThrowIf(result == null, "Chunk not found with hash of ({0})", chunkHash);         
            Task.Run(() => Path.Combine(ChunkDirectory, chunkHash).SafeWriteFile(result.Data, true));
            return result;
        }

        [Local]
        public ChunkData GetChunkDataFromFileSystem(string chunkHash)
        {
            return ChunkData.FromChunk(FileSystemChunkStorage.GetChunk(chunkHash));
        }

        /// <summary>
        /// Save the specified file into chunk storage
        /// </summary>
        /// <param name="file"></param>
        /// <param name="chunkLength"></param>
        /// <returns></returns>
        [Local]
        public ChunkedFileDescriptor StoreFileChunks(FileInfo file, string description = null)
        {
            ChunkedFileReader chunked = new ChunkedFileReader(file, ChunkLength);
            ChunkedFileDescriptor chunkedFileDescriptor = chunked.ToChunkedFileDescriptor(description);
            SaveFileDescriptor(chunkedFileDescriptor);

            foreach (ChunkedFileDataDescriptor chunkFileDataDescriptor in chunked.ToChunkedFileDataDescriptor())
            {
                ChunkData chunk = chunkFileDataDescriptor.ChunkData;
                SaveChunkData(chunk);
                ChunkDataDescriptor xref = chunkFileDataDescriptor.ChunkDataDescriptor;
                SaveChunkDataDescriptor(xref);
            }
            return chunkedFileDescriptor;
        }

        [Local]
        public FileInfo RestoreFile(ChunkedFileDescriptor fileDescriptor, string localPath = null)
        {
            return RestoreFile(fileDescriptor.FileHash, localPath ?? Path.Combine(fileDescriptor.OriginalDirectory, fileDescriptor.FileName));
        }

        [Local]
        public FileInfo RestoreFile(string fileHash, string localPath, bool overwrite = true)
        {
            HandleExistingFile(localPath, overwrite);
            FileInfo file = new FileInfo(localPath);
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            using (FileStream fs = new FileStream(localPath, FileMode.Create))
            {
                WriteFileHashToStream(fileHash, fs);
            }
            file.Refresh();
            return file;
        }

        [Local]
        public FileInfo WriteFileDataToDirectory(string fileNameOrHash, string directoryPath)
        {
            ChunkedFileDescriptor fileDescriptor = GetFileDescriptor(fileNameOrHash);
            Args.ThrowIfNull(fileDescriptor, "fileDescriptor");
            string localPath = Path.Combine(directoryPath, fileDescriptor.FileName);
            FileInfo file = new FileInfo(localPath);
            if (File.Exists(localPath) && !fileDescriptor.FileHash.Equals(file.Sha256()))
            {
                File.Delete(localPath);
            }
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            if (!File.Exists(localPath))
            {
                using(FileStream fs = new FileStream(localPath, FileMode.Create))
                {
                    WriteFileHashToStream(fileDescriptor.FileHash, fs);
                }
            }
            file.Refresh();
            return file;
        }

        [Local]
        public void WriteFileToStream(string fileNameOrHash, Stream stream)
        {
            ChunkedFileDescriptor fileDescriptor = GetFileDescriptor(fileNameOrHash);
            Args.ThrowIfNull(fileDescriptor, "fileDescriptor");
            WriteFileHashToStream(fileDescriptor.FileHash, stream);
        }

        [Local]
        public void WriteFileHashToStream(string fileHash, Stream fs)
        {
            List<FileChunk> chunks = GetFileChunks(fileHash, -1);
            while (chunks.Count > 0)
            {
                foreach (FileChunk chunk in chunks)
                {
                    fs.Write(chunk.ByteData, 0, chunk.ByteData.Length);
                }
                chunks = GetFileChunks(fileHash, (int)(chunks[chunks.Count - 1].ChunkIndex));
            }
        }

        public virtual List<FileChunk> GetFileChunks(string fileHash, int fromIndex)
        {
            return GetFileChunks(fileHash, fromIndex, ChunkDataBatchSize);
        }

        protected IDataDirectoryProvider DataProvider { get; }

        private static void HandleExistingFile(string localPath, bool overwrite)
        {
            if (File.Exists(localPath))
            {
                if (overwrite)
                {
                    File.Delete(localPath);
                }
                else
                {
                    throw new InvalidOperationException($"File already exists: {localPath}");
                }
            }
        }

        private void SetChunkDataDescriptorRetriever()
        {
            if (Repository is DaoRepository daoRepo)
            {
                ChunkDataDescriptorRetriever = (fileHash, fromIndex, chunkDataBatchSize) => daoRepo.Top<ChunkDataDescriptor>(chunkDataBatchSize,
                    Filter.Where(nameof(ChunkDataDescriptor.FileHash)) == fileHash &&
                    Filter.Where(nameof(ChunkDataDescriptor.ChunkIndex)) > fromIndex);
            }
            else
            {
                Logger.Warning("{0}::FileService.Repository is not a DaoRepository but is a ({1}), good luck with that!", nameof(SetChunkDataDescriptorRetriever), Repository.GetType().Name);
                ChunkDataDescriptorRetriever = (fileHash, fromIndex, chunkDataBatchSize) => Repository.Query<ChunkDataDescriptor>(
                        Filter.Where(nameof(ChunkDataDescriptor.FileHash)) == fileHash &&
                        Filter.Where(nameof(ChunkDataDescriptor.ChunkIndex)) > fromIndex)
                    .Take(chunkDataBatchSize);
            }
        }
    }
}
