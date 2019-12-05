using Nba.Api.Dtos;
using Newtonsoft.Json;
using System.Net.Http;

namespace Nba.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HttpClient httpClient = new HttpClient();

            HttpResponseMessage result = httpClient.GetAsync("http://data.nba.net/10s/prod/v1/today.json").Result;

            NbaRoot root = JsonConvert.DeserializeObject<NbaRoot>(result.Content.ReadAsStringAsync().Result);
        }
    }
}
