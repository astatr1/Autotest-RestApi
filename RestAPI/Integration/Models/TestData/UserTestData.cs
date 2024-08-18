using RestAPI.Integration.Models.RestAPI;

namespace RestAPI.Integration.Models.TestData
{
    public class UserTestData
    {
        public int UserId { get; set; }
        public int ExpectedStatusCode { get; set; }
        public User ExpectedUser { get; set; }
    }
}
