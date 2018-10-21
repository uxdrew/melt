using Melt.SynchronyObjects;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Dynamic;

namespace Melt
{
    public class SynchronyAPICaller
    {

        public static AccessToken GetAccessToken()
        {
            var client = new RestClient("https://api-stg.syf.com/oauth2/v1/token");
            var request = new RestRequest(Method.POST);
            request.AddHeader("token_type", "Bearer");
            request.AddHeader("client_id", "LBgiP8nDwHvDvzrR6UqSLCNngiYz4DPq");
            request.AddHeader("access_token", "LzbizLTnhz8cZz0MO2I7H7Bfny2B");
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<AccessToken>(response.Content);
        }

        public static AccessToken SydneyDueCheck(string accessToken)
        {
            var client = new RestClient("https://api-stg.syf.com/m2020/sydney/v1/conversations");
            var request = new RestRequest(Method.POST);
            request.AddHeader("sessionID", Guid.NewGuid().ToString());
            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<AccessToken>(response.Content);
        }

        public static AccessToken SydneyCurrentBalance(string question, string accessToken)
        {
            var client = new RestClient("https://api-stg.syf.com/m2020/sydney/v1/conversations");
            var request = new RestRequest(Method.POST);
            request.AddHeader("sessionID", Guid.NewGuid().ToString());
            request.AddHeader("Authorization", "Bearer " + accessToken);
            request.AddHeader("Content-Type", "application/json");

            dynamic body = new ExpandoObject();
            body.sessionID = Guid.NewGuid().ToString();
            body.question = question;
            body.origin = "Typed";
            body.channel = "Web";
            body.language = "en-US";
            request.AddBody(body);
            IRestResponse response = client.Execute(request);
            return JsonConvert.DeserializeObject<AccessToken>(response.Content);
        }
    }
}
