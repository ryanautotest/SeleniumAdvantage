using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SeleniumFramework.APICore;

namespace RookieTest.Services
{
    public class MockAPIService
    {
        public string userLoginPath = "/login";

        public APIResponse LoginRequest(string username, string password)
        {
            APIResponse response = new APIRequest()
                .SetUrl("https://demoqa.com" + "/login")
                .AddHeader("Content-Type", "application/x-www-form-urlencoded")
                .AddFormData("username", username)
                .AddFormData("password", password)
                .SendRequest();
            return response;
        }
    }
}
