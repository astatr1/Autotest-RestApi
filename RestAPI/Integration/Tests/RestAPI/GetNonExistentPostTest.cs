using RestAPI.Framework.Utils;
using RestAPI.Integration.Api;

namespace RestAPI.Integration.Tests.RestAPI
{
    public class GetNonExistentPostTest : BaseRestAPITest
    {
        [TestCase(150)]
        public void GetNonExistentPost(int postId)
        {
            var testData = GetTestDataByPostId(postId);
            var response = RestApiUtils.GetPost(postId);
            Assert.That((int)response.StatusCode, Is.EqualTo(testData.ExpectedStatusCode), $"Status code should be: {testData.ExpectedStatusCode}");
            Assert.That(response.Content.IsEmptyOrEmptyJsonObject(), "The response body should be empty");
        }
    }
}
