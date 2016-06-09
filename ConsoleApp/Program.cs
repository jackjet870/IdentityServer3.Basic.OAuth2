using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityModel.Client;
using System.Net.Http;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TokenResponse token = GetClientToken("Bob", "WhoAteMyCake");
            CallApi(token);
        }

        static TokenResponse GetClientToken(string userName, string passWord)
        {
            var client = new TokenClient(
                "http://localhost:5000/connect/token",
                "AppName_APIClient",
                "21B5F798-BE55-42BC-8AA8-0025B903DC3B");

            return client.RequestResourceOwnerPasswordAsync(userName, passWord, "AppName_API").Result;
        }
        static void CallApi(TokenResponse response)
        {
            var client = new HttpClient();
            client.SetBearerToken(response.AccessToken);

            Console.WriteLine(client.GetStringAsync("http://localhost:61050/test").Result);
        }
    }
}
