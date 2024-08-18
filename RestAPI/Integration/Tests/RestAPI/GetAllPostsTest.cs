using Newtonsoft.Json;
using RestAPI.Integration.Api;
using RestAPI.Integration.Models.RestAPI;

namespace RestAPI.Integration.Tests.RestAPI
{
    [TestFixture]
    public class GetAllPostsTest : BaseRestAPITest
    {
        [Test]
        public void GetAllPosts()
        {
            var response = RestApiUtils.GetPosts();
            Assert.That((int)response.StatusCode, Is.EqualTo(200), $"Status code should be: 200");

            var posts = JsonConvert.DeserializeObject<List<Post>>(response.Content);
            Assert.That(posts.SequenceEqual(posts.OrderBy(post => post.Id)), "Posts should be sorted in ascending order by Id");
        }
    }
}
