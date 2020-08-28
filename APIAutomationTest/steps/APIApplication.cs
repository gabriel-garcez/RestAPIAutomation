using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace APIAutomationTest.steps
{
    [Binding]
    public sealed class APIApplication
    {
        [Given(@"i have an endpoint (.*)")]
        public void GivenIHaveAnEndpointEndpoint(string endpoint)
        {
            RestAPIHelper.SetUrl(endpoint);
        }

        [When(@"I call get method of api")]
        public void WhenICallGetMethodOfApi()
        {
            RestAPIHelper.CreateRequest();

         }

        [Then(@"I get api response in json format")]
        public void ThenIGetApiResponseInJsonFormat()
        {
            var expected = "something";
            var response = RestAPIHelper.GetResponse();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.That(response.Content, Is.EqualTo(expected), "Error Message");
            }
        }

    }
}
