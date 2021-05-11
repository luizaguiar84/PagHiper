using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace PagHiper.Services
{
	public class RequestService
	{
		public static RestClient GetClient()
		{
			var client = new RestClient
			{
				BaseUrl = new Uri("https://api.paghiper.com/")
			};
			client.AddDefaultHeader("Accept", "Application/json");
			return client;
		}
	}
}
