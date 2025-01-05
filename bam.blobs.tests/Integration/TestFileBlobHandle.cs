using Bam.Blobs;

namespace Bam.Application.Unit;

public class TestFileBlobHandle : FileBlob
{
    public TestFileBlobHandle(string filePath) : base(filePath)
    {
    }

    public TestFileBlobHandle(FileInfo file, int chunkSize = 256000) : base(file, chunkSize)
    {
    }

    public long TailLengthAccessor
    {
        get => this.TailSize;
    }
}