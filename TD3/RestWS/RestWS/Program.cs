using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace RestWS
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            HttpResponseMessage response = await client.GetAsync("https://api.jcdecaux.com/vls/v3/contracts?apiKey=78f4c26aa0c05ab2ffe2ad7e19945b37bdba938e");
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(responseBody);

            //string jsonString = JsonSerializer.Serialize(responseBody);
            //Console.WriteLine(jsonString);

            List<Contrat> contrats = JsonSerializer.Deserialize<List<Contrat>>(responseBody);
            foreach (Contrat contrat in contrats)
            {
                Console.WriteLine(contrat);
            }
           
            Console.ReadLine();
        }
    }
}
