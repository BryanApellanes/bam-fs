namespace Bam.Blobs;

public interface IHmacKeyProvider
{
    byte[] GetHmacKey();
}