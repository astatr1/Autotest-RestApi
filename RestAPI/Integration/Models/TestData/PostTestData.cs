using RestAPI.Integration.Models.RestAPI;

namespace RestAPI.Integration.Models.TestData
{
    public class PostTestData
    {
        public int PostId { get; set; }
        public int ExpectedStatusCode { get; set; }
        public Post ExpectedPost { get; set; }
    }
}
