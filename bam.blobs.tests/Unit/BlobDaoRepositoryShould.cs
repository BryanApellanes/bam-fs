using Bam.Blobs;
using Bam.Blobs.Data;
using Bam.Blobs.Data.Dao.Repository;
using Bam.Test;

namespace Bam.Application.Unit;

[UnitTestMenu("BlobDaoRepositoryShould")]
public class BlobDaoRepositoryShould: UnitTestMenuContainer
{
    [UnitTest]
    public async Task SaveDataInstances()
    {
        BlobsRepository repo = new BlobsRepository();
        if (repo == null)
        {
            Args.Throw<ArgumentNullException>("default repo was null");
        }

        string testHash = 32.RandomLetters();
        BlobDescriptorData data = repo.Save(new BlobDescriptorData()
        {
            BlobHash = testHash
        });
        
        data.ShouldNotBeNull();
        data.BlobHash.ShouldBeEqualTo(testHash);
        data.Id.ShouldBeGreaterThan(0);
        
    }
}