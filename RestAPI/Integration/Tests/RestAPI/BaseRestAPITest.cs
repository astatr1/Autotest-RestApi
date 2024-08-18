using Aquality.Selenium.Core.Logging;
using RestAPI.Framework.ConfigManager;
using RestAPI.Framework.Utils;
using RestAPI.Integration.Models.TestData;

namespace RestAPI.Integration.Tests.RestAPI
{
    [TestFixture]
    public class BaseRestAPITest
    {
        protected List<PostTestData> postTestData;
        protected List<UserTestData> userTestData;
        protected List<CreatingPostTestData> creatingPostTestData;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            postTestData = JsonFileReader.ReadFromFile<List<PostTestData>>(PathHelper.GetFullPath(ConfigManager.PostsTestDataPath));
            userTestData = JsonFileReader.ReadFromFile<List<UserTestData>>(PathHelper.GetFullPath(ConfigManager.UsersTestDataPath));
            creatingPostTestData = JsonFileReader.ReadFromFile<List<CreatingPostTestData>>(PathHelper.GetFullPath(ConfigManager.CreatingPostTestDataPath));
        }

        [SetUp]
        public void SetUp()
        {
            var testName = TestContext.CurrentContext.Test.Name;
            Logger.Instance.Info($"Starting test: {testName}");
        }

        protected PostTestData GetTestDataByPostId(int postId) => postTestData.FirstOrDefault(post => post.PostId == postId);
        protected UserTestData GetTestDataByUserId(int userId) => userTestData.FirstOrDefault(user => user.UserId == userId);
        protected CreatingPostTestData GetTestDataForCreatePostByUserId(int userId) => creatingPostTestData.FirstOrDefault(user => user.ExpectedPost.UserId == userId);
    }
}
