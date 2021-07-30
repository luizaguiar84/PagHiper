using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
