using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestSharp;

namespace Melt
{
    public static class YodleeAPICaller
    {
        // Must do CobrandLogin before UserLogin.

        // CobrandLogin is the Company login. UserLogin is the individual login.
        public static void CobrandLogin()
        {
            var client = new RestClient("https://developer.api.yodlee.com/ysl/cobrand/login");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "0abd7156-4e4a-47fa-981c-f74de365462e");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Cobrand-Name", "restserver");
            request.AddHeader("Api-Version", "1.1");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("undefined", "{\r\n    \"cobrand\":{\r\n        \"cobrandLogin\":\"sbCobd7b717f7f57a9deec9bbd7f83f95654d6a\",\r\n        \"cobrandPassword\":\"2031221c-4190-45d8-a56b-494757732d1f\",\r\n        \"locale\":\"en_US\"\r\n    }\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }

        public static void UserLogin()
        {
            var client = new RestClient("https://developer.api.yodlee.com/ysl/user/login");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "454e17ff-6071-40da-8bfa-2fb4c74216ca");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Cobrand-Name", "restserver");
            request.AddHeader("Api-Version", "1.1");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "cobSession=08062013_0:32c28e9f46d4846e6504f520e68da450ec27ffd7d6a77bc0958f157177dd9d71061a325840c214c6b4a1b66d66ad3e1aac91837ed60e0a9078462afa1f632e27");
            request.AddParameter("undefined", "{\r\n    \"user\":{\r\n        \"loginName\":\"sbMemd7b717f7f57a9deec9bbd7f83f95654d6a2\",\r\n        \"password\":\"sbMemd7b717f7f57a9deec9bbd7f83f95654d6a2#123\",\r\n        \"locale\":\"en_US\"\r\n    }\r\n}", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
        }

        public static void GetAccessTokensForFastLink()
        {
            var client = new RestClient("https://developer.api.yodlee.com/ysl/user/accessTokens?appIds=10003600");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Postman-Token", "63e8a502-f87b-4bfa-8dd4-4fe39362afea");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Cobrand-Name", "restserver");
            request.AddHeader("Api-Version", "1.1");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "cobSession=08062013_0:32c28e9f46d4846e6504f520e68da450ec27ffd7d6a77bc0958f157177dd9d71061a325840c214c6b4a1b66d66ad3e1aac91837ed60e0a9078462afa1f632e27,userSession=08062013_0:972281bb688a451eefdad0761b0b84ebb7190b688b8293ee69ae0fdf693c9a333d1f35a1e58c2139b66b549c50857f72379a90e1e442718b266fed135cdea76d");
            IRestResponse response = client.Execute(request);
        }

        public static void GetAccounts()
        {
            var client = new RestClient("https://developer.api.yodlee.com/ysl/accounts");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Postman-Token", "7435550e-3ec1-4771-b3e1-62a6b0f9bf98");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Cobrand-Name", "restserver");
            request.AddHeader("Api-Version", "1.1");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "cobSession=08062013_0:32c28e9f46d4846e6504f520e68da450ec27ffd7d6a77bc0958f157177dd9d71061a325840c214c6b4a1b66d66ad3e1aac91837ed60e0a9078462afa1f632e27,userSession=08062013_0:972281bb688a451eefdad0761b0b84ebb7190b688b8293ee69ae0fdf693c9a333d1f35a1e58c2139b66b549c50857f72379a90e1e442718b266fed135cdea76d");
            IRestResponse response = client.Execute(request);
        }

        public static void GetTransactions()
        {
            var client = new RestClient("https://developer.api.yodlee.com/ysl/transactions?fromDate=2013-01-01");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Postman-Token", "4a64084e-80bf-43f3-b135-b0e7c6ed1e69");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Cobrand-Name", "restserver");
            request.AddHeader("Api-Version", "1.1");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "cobSession=08062013_0:32c28e9f46d4846e6504f520e68da450ec27ffd7d6a77bc0958f157177dd9d71061a325840c214c6b4a1b66d66ad3e1aac91837ed60e0a9078462afa1f632e27,userSession=08062013_0:972281bb688a451eefdad0761b0b84ebb7190b688b8293ee69ae0fdf693c9a333d1f35a1e58c2139b66b549c50857f72379a90e1e442718b266fed135cdea76d");
            IRestResponse response = client.Execute(request);
        }

        public static void UserLogout()
        {
            var client = new RestClient("https://developer.api.yodlee.com/ysl/user/logout");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "75b73aed-ff9e-4985-903e-2d94eda6e3a3");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Cobrand-Name", "restserver");
            request.AddHeader("Api-Version", "1.1");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "cobSession=08062013_0:32c28e9f46d4846e6504f520e68da450ec27ffd7d6a77bc0958f157177dd9d71061a325840c214c6b4a1b66d66ad3e1aac91837ed60e0a9078462afa1f632e27,userSession=08062013_0:972281bb688a451eefdad0761b0b84ebb7190b688b8293ee69ae0fdf693c9a333d1f35a1e58c2139b66b549c50857f72379a90e1e442718b266fed135cdea76d");
            IRestResponse response = client.Execute(request);
        }

        public static void CobrandLogout()
        {
            var client = new RestClient("https://developer.api.yodlee.com/ysl/cobrand/logout");
            var request = new RestRequest(Method.POST);
            request.AddHeader("Postman-Token", "84976c77-c176-4c8f-82a2-47d16b957171");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Cobrand-Name", "restserver");
            request.AddHeader("Api-Version", "1.1");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "cobSession=08062013_0:32c28e9f46d4846e6504f520e68da450ec27ffd7d6a77bc0958f157177dd9d71061a325840c214c6b4a1b66d66ad3e1aac91837ed60e0a9078462afa1f632e27");
            IRestResponse response = client.Execute(request);
        }
    }
}
