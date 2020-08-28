using System;
using System.IO;
using RestSharp;

namespace APIAutomationTest
{
    public static class RestAPIHelper
    {
        public static RestClient client;
        public static RestRequest restRequest;
        public static string baseUrl = "http://www.mydomain.com";

        public static RestClient SetUrl(string endpoint)
        {
            var Url = Path.Combine(baseUrl, endpoint);
            return client = new RestClient(Url);
        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;

        }

        public static IRestResponse GetResponse()
        {

            return client.Execute(restRequest);

        }

    }
}
