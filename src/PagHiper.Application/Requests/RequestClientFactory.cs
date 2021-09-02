using RestSharp;

namespace PagHiper.Application.Requests
{
    class RequestClientFactory
    {
        private const string PathApi = "https://api.paghiper.com/";

        public static RestClient GetClient()
        {
            var client = new RestClient(PathApi);
            client.AddDefaultHeader("Accept", "Application/json");
            return client;
        }
    }
}
