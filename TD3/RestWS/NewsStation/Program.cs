using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace NewsStation
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            string contratName = args[0];
            string stationNumber = args[1];
            HttpResponseMessage response = await client.GetAsync("https://api.jcdecaux.com/vls/v3/stations/" + stationNumber + "/?apiKey=78f4c26aa0c05ab2ffe2ad7e19945b37bdba938e&contract=" + contratName);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(responseBody);

            //string jsonString = JsonSerializer.Serialize(responseBody);
            //Console.WriteLine(jsonString);

            Station station = JsonSerializer.Deserialize<Station>(responseBody);
            Console.WriteLine(station);

            Console.ReadLine();
        }
    }
}
