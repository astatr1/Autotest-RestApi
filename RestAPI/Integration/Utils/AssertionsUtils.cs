using RestAPI.Integration.Models.RestAPI;
using RestAPI.Integration.Models.TestData;

namespace RestAPI.Integration.Utils
{
    public static class AssertionsUtils
    {
        public static void VerifyUser(User user, UserTestData testData)
        {
            Assert.Multiple(() =>
            {
                Assert.That(user.Name, Is.EqualTo(testData.ExpectedUser.Name), $"Name should be: {testData.ExpectedUser.Name}");
                Assert.That(user.Username, Is.EqualTo(testData.ExpectedUser.Username), $"Username should be: {testData.ExpectedUser.Username}");
                Assert.That(user.Email, Is.EqualTo(testData.ExpectedUser.Email), $"Email should be: {testData.ExpectedUser.Email}");
                Assert.That(user.Address.Street, Is.EqualTo(testData.ExpectedUser.Address.Street), $"Street should be: {testData.ExpectedUser.Address.Street}");
                Assert.That(user.Address.Suite, Is.EqualTo(testData.ExpectedUser.Address.Suite), $"Suite should be: {testData.ExpectedUser.Address.Suite}");
                Assert.That(user.Address.City, Is.EqualTo(testData.ExpectedUser.Address.City), $"City should be: {testData.ExpectedUser.Address.City}");
                Assert.That(user.Address.Zipcode, Is.EqualTo(testData.ExpectedUser.Address.Zipcode), $"Zipcode should be: {testData.ExpectedUser.Address.Zipcode}");
                Assert.That(user.Address.Geo.Lat, Is.EqualTo(testData.ExpectedUser.Address.Geo.Lat), $"Latitude should be: {testData.ExpectedUser.Address.Geo.Lat}");
                Assert.That(user.Address.Geo.Lng, Is.EqualTo(testData.ExpectedUser.Address.Geo.Lng), $"Longitude should be: {testData.ExpectedUser.Address.Geo.Lng}");
                Assert.That(user.Phone, Is.EqualTo(testData.ExpectedUser.Phone), $"User phone should be: {testData.ExpectedUser.Phone}");
                Assert.That(user.Website, Is.EqualTo(testData.ExpectedUser.Website), $"User website should be: {testData.ExpectedUser.Website}");
                Assert.That(user.Company.Name, Is.EqualTo(testData.ExpectedUser.Company.Name), $"Company name should be: {testData.ExpectedUser.Company.Name}");
                Assert.That(user.Company.CatchPhrase, Is.EqualTo(testData.ExpectedUser.Company.CatchPhrase), $"Company catchPhrase should be: {testData.ExpectedUser.Company.CatchPhrase}");
                Assert.That(user.Company.Bs, Is.EqualTo(testData.ExpectedUser.Company.Bs), $"Company Bs should be: {testData.ExpectedUser.Company.Bs}");
            });
        }

        public static void VerifyCreatedPost(Post createdPost, Post testData)
        {
            Assert.Multiple(() =>
            {
                Assert.That(createdPost.UserId, Is.EqualTo(testData.UserId), $"UserId should be: {testData.UserId}");
                Assert.That(createdPost.Title, Is.EqualTo(testData.Title), $"Title should be: {testData.Title}");
                Assert.That(createdPost.Body, Is.EqualTo(testData.Body), $"Body should be: {testData.Body}");
                Assert.That(createdPost.Id, Is.GreaterThan(0), $"Id should be greater than 0");
            });
        }
    }
}

