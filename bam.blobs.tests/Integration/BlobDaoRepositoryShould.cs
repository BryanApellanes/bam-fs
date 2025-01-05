using Bam.Blobs;
using Bam.Blobs.Data;
using Bam.Blobs.Data.Dao.Repository;
using Bam.Test;

namespace Bam.Application.Unit;

[UnitTestMenu("BlobDaoRepositoryShould")]
public class BlobDaoRepositoryShould: UnitTestMenuContainer
{
    [UnitTest]
    public void SaveDataInstances()
    {
        BlobDataRepository repo = new BlobDataRepository();
        if (repo == null)
        {
            Args.Throw<ArgumentNullException>("default repo was null");
        }

        string testHash = 32.RandomLetters();
        BlobHandleData data = repo.Save(new BlobHandleData()
        {
            BlobHash = testHash
        });
        
        data.ShouldNotBeNull();
        data.BlobHash.ShouldBeEqualTo(testHash);
        data.Id.ShouldBeGreaterThan(0);
    }
    
    [UnitTest]
    public void FindBlobHandleByHash()
    {
        BlobDataRepository repo = new BlobDataRepository();

        string testHash = 32.RandomLetters();
        BlobHandleData data = repo.Save(new BlobHandleData()
        {
            BlobHash = testHash
        });

        BlobHandleData retrieved = repo.OneBlobHandleDataWhere(c => c.BlobHash == testHash);
        retrieved.ShouldNotBeNull();
        retrieved.Id.ShouldEqual(data.Id);
        retrieved.BlobHash.ShouldEqual(testHash);
    }
}