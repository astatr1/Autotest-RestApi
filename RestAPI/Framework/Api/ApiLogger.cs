using Aquality.Selenium.Core.Logging;
using RestSharp;

namespace RestAPI.Framework.Api
{

    public static class ApiLogger
    {
        public static void LogRequest(RestClient client, RestRequest request)
        {
            var logger = Logger.Instance;
            logger.Info($"Executing request: {request.Method} {client.Options.BaseUrl}{request.Resource}");
        }

        public static void LogResponse(RestResponse response)
        {
            var logger = Logger.Instance;
            logger.Info($"Response Status: {response.StatusCode}");

            if (response.Content != null)
            {
                logger.Info($"Response Body: {response.Content}");
            }
        }
    }
}

