using NUnit.Framework;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostmanDemo.Services;
using RestSharp;

namespace TestCase
{
    [TestFixture]
    public class APITest1 : RestSharpAPIService
    {

        public string endPoint = "/todos";
        public string URL = "https://apichallenges.herokuapp.com";
        [Test]
        public async Task GetListID()
        {
            RestSharpAPIService apiService = new RestSharpAPIService();
            RestResponse response = await apiService.GetList(URL, endPoint);
            Assert.AreEqual("200", response.StatusCode);
        }
    }
}
