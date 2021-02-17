using System;
using RestSharp;
using Newtonsoft.Json;

// RestSharp
// Newtonsoft Json

namespace APIklient
{
  class Program
  {
    static void Main(string[] args)
    {
      RestClient client = new RestClient("https://swapi.dev/api/");

      RestRequest request = new RestRequest("people/12/");
      string apikey = "strhetbertyhjetyj";

      request.AddParameter("apikey", apikey);

      IRestResponse response = client.Get(request);

      // Console.WriteLine(response.Content);

      // Pokemon charmander = JsonConvert.DeserializeObject<Pokemon>(response.Content);
      People tarkin = JsonConvert.DeserializeObject<People>(response.Content);

      Console.WriteLine(tarkin.height);

      Console.ReadLine();

    }
  }
}
