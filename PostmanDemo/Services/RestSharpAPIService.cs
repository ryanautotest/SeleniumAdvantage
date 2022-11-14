using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using DataTransferObject;
using SeleniumFramework.APIRestSharp;

namespace PostmanDemo.Services
{
    public class RestSharpAPIService
    {
        private RestSharpHelper helper;

        public RestSharpAPIService()
        {
            helper = new RestSharpHelper();
        }
        
        public async Task<RestResponse> GetList(string URL, string endpoint)
        {
            RestClient client = helper.SetURL(URL, endpoint);
            RestRequest request = helper.CreateGetRequest();
            request.RequestFormat = DataFormat.Json;
            RestResponse response = await helper.GetResponseAsync(client,request);
            return response;
        }




    }
}
