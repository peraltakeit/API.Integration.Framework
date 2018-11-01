using Api.Integration.Framework.Helpers;
using Api.Integration.Framework.Models;
using Newtonsoft.Json;
using RestSharp;

namespace Api.Integration.Framework.APICalls
{
    class Calls
    {
        public void CreateSomething()
        {
            var restRequests = new RestRequests();
            var testModel = new TestModel();
            string testString = null;

            IRestResponse response = restRequests.PostRequest();
            testModel = JsonConvert.DeserializeObject<TestModel>(response.Content); //post request response is stored in your model
            testString = testModel.Test.TestString; //a specific object/item in your model is accessed this way
        }

        public TestModel GetSomething()
        {
            var restRequests = new RestRequests();
            var testModel = new TestModel();

            IRestResponse response = restRequests.GetRequest();
            testModel = JsonConvert.DeserializeObject<TestModel>(response.Content); //get request response is stored in your model

            return testModel; //return whatever is in your model after it has been deserialized.
        }
    }
}
