using Newtonsoft.Json;
using RestAPI.Integration.Api;
using RestAPI.Integration.Models.RestAPI;
using RestAPI.Integration.Utils;

namespace RestAPI.Integration.Tests.RestAPI
{
    public class GetUserByIdTest : BaseRestAPITest
    {
        [TestCase(5)]
        public void GetUserById(int userId)
        {
            var testData = GetTestDataByUserId(userId);
            var response = RestApiUtils.GetUser(testData.UserId);

            Assert.That((int)response.StatusCode, Is.EqualTo(testData.ExpectedStatusCode), $"Status code should be: {testData.ExpectedStatusCode}");
            var user = JsonConvert.DeserializeObject<User>(response.Content);

            AssertionsUtils.VerifyUser(user, testData);
        }
    }
}
