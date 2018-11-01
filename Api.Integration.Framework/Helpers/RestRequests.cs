using RestSharp;

namespace Api.Integration.Framework.Helpers
{
    class RestRequests
    {
        public IRestResponse PostRequest()
        {
            var client = new RestClient("Client URL here");
            var request = new RestRequest("Endpoint here", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "Token here");
            request.AddBody("Add body here"); //Can be an object, used multiple times/whatever

            IRestResponse response = client.Execute(request);
            return response;
        }

        public IRestResponse GetRequest()
        {
            var client = new RestClient("Client URL here");
            var request = new RestRequest("Endpoint here", Method.GET);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Authorization", "Token here");

            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}
