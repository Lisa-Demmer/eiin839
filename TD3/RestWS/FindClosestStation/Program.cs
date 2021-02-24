using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FindClosestStation
{
    class Program
    {
        static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            string contratName = args[0];
            GeoCoordinate coord = new GeoCoordinate(Convert.ToDouble(args[1]), Convert.ToDouble(args[2]));
            HttpResponseMessage response = await client.GetAsync("https://api.jcdecaux.com/vls/v3/stations?apiKey=78f4c26aa0c05ab2ffe2ad7e19945b37bdba938e&contract=" + contratName);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(responseBody);

            //string jsonString = JsonSerializer.Serialize(responseBody);
            //Console.WriteLine(jsonString);

            List<Station> stations = JsonSerializer.Deserialize<List<Station>>(responseBody);
            
            Station nearestStation = null;
            double bestDistance = 0;
            foreach (Station station in stations)
            {
                if(nearestStation == null)
                {
                    nearestStation = station;
                    bestDistance = coord.GetDistanceTo(new GeoCoordinate(station.position.latitude, station.position.longitude));
                }
                else if (coord.GetDistanceTo(new GeoCoordinate(station.position.latitude, station.position.longitude)) < bestDistance)
                {
                    nearestStation = station;
                    bestDistance = coord.GetDistanceTo(new GeoCoordinate(station.position.latitude, station.position.longitude));
                }
            }
            Console.WriteLine(nearestStation);
            Console.ReadLine();
        }
    }
}
