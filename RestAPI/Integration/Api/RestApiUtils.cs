using RestAPI.Framework.Api;
using RestAPI.Framework.ConfigManager;
using RestAPI.Integration.Models.RestAPI;
using RestSharp;

namespace RestAPI.Integration.Api
{
    public static class RestApiUtils
    {
        private static string BaseUrl = ConfigManager.BaseUrl;
        private const string UsersEndpoint = "users";
        private const string PostsEndpoint = "posts";

        public static RestResponse<User> GetUser(int id) => ApiRequestExecutor.ExecuteGetRequest<User>(BaseUrl, $"{UsersEndpoint}/{id}");
        public static RestResponse<List<User>> GetUsers() => ApiRequestExecutor.ExecuteGetRequest<List<User>>(BaseUrl, UsersEndpoint);
        public static RestResponse<Post> GetPost(int id) => ApiRequestExecutor.ExecuteGetRequest<Post>(BaseUrl, $"{PostsEndpoint}/{id}");
        public static RestResponse<List<Post>> GetPosts() => ApiRequestExecutor.ExecuteGetRequest<List<Post>>(BaseUrl, PostsEndpoint);
        public static RestResponse CreatePost(Post newPost) => ApiRequestExecutor.ExecutePostRequest<object>(BaseUrl, PostsEndpoint, newPost);
    }
}
