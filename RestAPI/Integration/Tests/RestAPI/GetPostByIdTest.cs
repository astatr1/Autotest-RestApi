using Newtonsoft.Json;
using RestAPI.Integration.Api;
using RestAPI.Integration.Models.RestAPI;

namespace RestAPI.Integration.Tests.RestAPI
{
    public class GetPostByIdTest : BaseRestAPITest
    {
        [TestCase(99)]
        public void GetPostById(int postId)
        {
            var testData = GetTestDataByPostId(postId);
            var response = RestApiUtils.GetPost(testData.PostId);
            Assert.That((int)response.StatusCode, Is.EqualTo(testData.ExpectedStatusCode), $"Status code should be: {testData.ExpectedStatusCode}");
            var postResponse = JsonConvert.DeserializeObject<Post>(response.Content);

            Assert.That(postResponse.UserId, Is.EqualTo(testData.ExpectedPost.UserId), $"userId should be: {testData.ExpectedPost.UserId}");
            Assert.That(postResponse.Id, Is.EqualTo(testData.PostId), $"id should be: {testData.PostId}");
            Assert.IsFalse(string.IsNullOrEmpty(postResponse.Title), $"Title should not be empty");
            Assert.IsFalse(string.IsNullOrEmpty(postResponse.Body), $"Body should not be empty");
        }
    }
}
