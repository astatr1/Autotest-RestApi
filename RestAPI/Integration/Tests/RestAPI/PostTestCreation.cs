using Newtonsoft.Json;
using RestAPI.Integration.Api;
using RestAPI.Integration.Models.RestAPI;
using RestAPI.Integration.Utils;

namespace RestAPI.Integration.Tests.RestAPI
{
    public class PostTestCreation : BaseRestAPITest
    {
        [TestCase(1)]
        public void CreatePost(int userId)
        {
            var testData = GetTestDataForCreatePostByUserId(userId);
            var chars = RandomUtility.UpperCaseLatin + RandomUtility.LowerCaseLatin;
            var newPost = new Post
            {
                UserId = userId,
                Title = RandomUtility.RandomString(testData.ExpectedPost.TitleLength, chars),
                Body = RandomUtility.RandomString(testData.ExpectedPost.BodyLength, chars)
            };

            var response = RestApiUtils.CreatePost(newPost);
            Assert.That((int)response.StatusCode, Is.EqualTo(testData.ExpectedStatusCode), $"Status code should be: {testData.ExpectedStatusCode}");
            var createdPost = JsonConvert.DeserializeObject<Post>(response.Content);

            AssertionsUtils.VerifyCreatedPost(createdPost, newPost);
        }
    }
}
