﻿using Bam.Net.CoreServices.Files;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bam.Data;
using Bam.Data.Repositories;
using Bam.Logging;
using Bam.Net.Services.Chunking;


namespace Bam.Chunking
{
    /// <summary>
    /// An IChunkStorage implementation that stores chunks in the file system.
    /// </summary>
    /// <seealso cref="IChunkStorage" />
    public class FileSystemChunkStorage: IChunkStorage
    {
        public FileSystemChunkStorage()
        {
            DataProvider = Data.Repositories.DataProvider.Current;
            Logger = Log.Default;
        }

        public FileSystemChunkStorage(DataProvider dataProvider, ILogger logger = null)
        {
            DataProvider = dataProvider;
            Logger = logger;
        }

        public IDataDirectoryProvider DataProvider { get; set; }
        public ILogger Logger { get; set; }
        public void SetChunk(IChunk chunk)
        {
            SetChunk(chunk, true);
        }

        public IChunk GetChunk(string chunkHash)
        {
            if (ChunkExists(chunkHash, out IChunk chunk))
            {
                return chunk;
            }
            else
            {
                Task.Run(() => Logger.AddEntry("Chunk not found: {0}", LogEventType.Warning, chunkHash));
            }
            return null;
        }

        protected IChunk SetChunk(IChunk chunk, bool force)
        {
            if (ChunkExists(chunk.Hash, out IChunk result) && !force)
            {
                return result;
            }

            FileInfo file = new FileInfo(GetChunkFilePath(chunk.Hash));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }
            File.WriteAllBytes(file.FullName, chunk.Data);
            return chunk;
        }

        private bool ChunkExists(string hash, out IChunk chunk)
        {
            string filePath = GetChunkFilePath(hash);
            bool result = File.Exists(filePath);
            if (!result)
            {
                chunk = null;
                return result;
            }

            chunk = new Chunk
            {
                Hash = hash,
                Data = File.ReadAllBytes(filePath)
            };
            return result;
        }

        private string GetChunkFilePath(string hash)
        {
            return Path.Combine(GetChunkDirectoryPath(hash), "chunk");
        }

        private string GetChunkDirectoryPath(string hash)
        {
            DirectoryInfo chunksDir = DataProvider.GetChunksDirectory();
            return Path.Combine(chunksDir.FullName, Path.Combine(hash.SplitByLength(2).ToArray()));
        }        
    }
}
