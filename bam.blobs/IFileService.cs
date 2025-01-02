using System.Collections.Generic;
using System.IO;
using Bam.Files;
using Bam.Files.Data;

namespace Bam.Net.CoreServices.Files
{
    /// <summary>
    /// When implemented provides a mechanism for saving and restoring
    /// files of any kind.
    /// </summary>
    public interface IFileService
    {
        int ChunkDataBatchSize { get; }
        string ChunkDirectory { get; }
        int ChunkLength { get; }

        ChunkData GetChunkData(string chunkHash);
        ChunkData GetChunkDataFromFileSystem(string chunkHash);
        ChunkData GetChunkDataFromRepository(string chunkHash);
        List<FileChunk> GetFileChunks(string fileHash, int fromIndex);
        List<FileChunk> GetFileChunks(string fileHash, int fromIndex, int batchSize);
        BlobDescriptorData GetFileDescriptor(string fileHashOrName);
        BlobDescriptorData GetFileDescriptorByFileHash(string fileHash);
        IEnumerable<BlobDescriptorData> GetFileDescriptorsByFileName(string fileName, string originalDirectory = null);
        FileWriter GetFileWriter(string fileHash);
        FileInfo RestoreFile(BlobDescriptorData fileDescriptor, string localPath = null);
        FileInfo RestoreFile(string fileHash, string localPath, bool overwrite = true);
        void SaveChunkData(ChunkData chunk);
        BlobChunkAssociationData SaveChunkDataDescriptor(BlobChunkAssociationData xref);
        BlobDescriptorData SaveFileDescriptor(BlobDescriptorData fileDescriptor);
        BlobDescriptorData StoreFileChunks(FileInfo file, string description = null);
        void WriteFileHashToStream(string fileHash, Stream fs);
        FileInfo WriteFileDataToDirectory(string fileNameOrHash, string directoryPath);
        void WriteFileToStream(string fileNameOrHash, Stream stream);
        IEnumerable<FileChunk> YieldFileChunks(string fileHash, int fromIndex, int batchSize);
        IEnumerable<BlobDescriptorData> ListFiles(string rootPath = ".");
    }
}