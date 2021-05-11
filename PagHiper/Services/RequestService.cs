using RestSharp;

namespace PagHiper.Services
{
	public class RequestService
	{
		private const string PathApi = "https://api.paghiper.com/";
		
		private static RestClient GetClient()
		{
			var client = new RestClient(PathApi);

			client.AddDefaultHeader("Accept", "Application/json");
			return client;
		}

		public static IRestResponse GetResponse(string resource, object obj)
		{
			var client = GetClient();
			var request = new RestRequest(resource);
			request.AddJsonBody(obj);

			return client.Post(request);
		}
	}
}
