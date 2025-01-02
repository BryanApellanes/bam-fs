using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Bam.Files;
using Bam.Files.Data;
using Bam.Logging;

namespace Bam.Net.CoreServices.Files
{
    public class FileWriter: IFileBlob
    {
        internal FileWriter()
        {

        }

        internal FileWriter(IFileService fileService)
        {
            FileService = fileService;
        }

        public IFileService FileService { get; set; }

        public long ChunkCount { get; set; }

        public int ChunkLength { get; set; }

        public string Hash { get; set; }

        public long Length { get; set; }

        public string Title { get; set; }

        public string Directory { get; set; }
        public ILogger Logger { get; set; }

        public static FileWriter FromFileHash(IFileService svc, string fileHash, ILogger logger = null)
        {
            BlobDescriptorData descriptor = svc.GetFileDescriptor(fileHash);
            FileWriter writer = new FileWriter(svc)
            {
                Hash = fileHash,
                ChunkCount = descriptor.ChunkCount,
                ChunkLength = descriptor.ChunkLength,
                Length = descriptor.Length,
                //FileName = descriptor.FileName,
                //OriginalDirectory = descriptor.OriginalDirectory, 
                Logger = logger
            };
            return writer;
        }
        
        public Task Write(string localPath)
        {
            return Task.Run(() => FileService.RestoreFile(Hash, localPath));
        }
    }
}
