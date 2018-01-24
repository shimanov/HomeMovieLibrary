using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TmdbAPI
{
    public class SearchMovie
    {
        public const string typeContent = "movie?";

        static async Task GetMovieAsync(string apiKey, string language, string query)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("apllication/json"));
            var stringTask = client.GetStringAsync("https://api.themoviedb.org/3/search/" + typeContent
                + "api_key=" + apiKey
                + "&language=" + language
                + "&query=" + query);

            var stringResult = await stringTask;
            JObject obj = JObject.Parse(stringResult);
            var jsnResult =
                obj.DescendantsAndSelf()
                .OfType<JProperty>()
                .Where(p => p.Name == "title")
                .Select(p => p.Value);


            //foreach (var j in jsnResult)
            //{
            //    Console.WriteLine(j);
            //}

            //Console.ReadKey();
        }
    }
}
