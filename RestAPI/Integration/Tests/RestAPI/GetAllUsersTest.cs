using Newtonsoft.Json;
using RestAPI.Integration.Api;
using RestAPI.Integration.Models.RestAPI;
using RestAPI.Integration.Utils;

namespace RestAPI.Integration.Tests.RestAPI
{
    public class GetAllUsersTest : BaseRestAPITest
    {
        [TestCase(5)]
        public void GetAllUsers(int userId)
        {
            var testData = GetTestDataByUserId(userId);
            var response = RestApiUtils.GetUsers();
            Assert.That((int)response.StatusCode, Is.EqualTo(testData.ExpectedStatusCode), $"Status code should be: {testData.ExpectedStatusCode}");

            var users = JsonConvert.DeserializeObject<List<User>>(response.Content);
            Assert.IsNotNull(users, "The list of users should not be empty");

            var user = users.FirstOrDefault(user => user.Id == testData.UserId);
            AssertionsUtils.VerifyUser(user, testData);
        }
    }
}
