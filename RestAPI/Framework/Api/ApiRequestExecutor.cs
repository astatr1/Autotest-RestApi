using RestSharp;

namespace RestAPI.Framework.Api
{
    public static class ApiRequestExecutor
    {
        public static RestResponse<T> ExecuteGetRequest<T>(string BaseUrl, string endpoint)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest(endpoint, Method.Get);

            ApiLogger.LogRequest(client, request);
            var response = client.Execute<T>(request);
            ApiLogger.LogResponse(response);
            return response;
        }

        public static RestResponse<T> ExecutePostRequest<T>(string BaseUrl, string endpoint, object body)
        {
            var options = new RestClientOptions(BaseUrl);
            var client = new RestClient(options);
            var request = new RestRequest(endpoint, Method.Post);

            if (body != null)
            {
                request.AddJsonBody(body);
            }

            ApiLogger.LogRequest(client, request);
            var response = client.Execute<T>(request);
            ApiLogger.LogResponse(response);
            return response;
        }
    }
}
