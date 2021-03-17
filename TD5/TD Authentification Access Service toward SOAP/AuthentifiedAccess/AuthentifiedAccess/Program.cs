using System;

namespace AuthentifiedAccess
{
    class Program
    {
        static private Authenticator auth = new Authenticator();
        static void Main(string[] args)
        {

            
            Console.WriteLine("Enter username : ");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password : ");
            string password = Console.ReadLine();
            ServiceAuthenticator.AuthenticatorClient authService = new ServiceAuthenticator.AuthenticatorClient();
            bool isvalid = authService.ValidateCredentials(username, password); 
           //auth.ValidateCredentials(username, password);
            
            if(isvalid)
            {
                Console.WriteLine("Your are authenticated!");
                Console.WriteLine("enter a city name:");
                string city = Console.ReadLine();
                ServiceWeather.AccessClient service = new ServiceWeather.AccessClient();
                Console.WriteLine(service.Weather(city));
                //ServiceAccess srv = new ServiceAccess();
                //srv.Weather(city);

            } 
            else
                Console.WriteLine("Your are NOT authenticated!");
            Console.ReadLine();     
        }
    }
}
