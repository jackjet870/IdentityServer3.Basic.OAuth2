using IdentityServer3.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer
{
    static class Clients
    {
        public static List<Client> Get()
        {
            return new List<Client>
            {
                //// no human involved
                //new Client
                //{
                //    ClientName = "Then Event Web Application",
                //    ClientId = "ThenEventApp",
                //    Enabled = true,
                //    AccessTokenType = AccessTokenType.Reference,

                //    Flow = Flows.ClientCredentials,

                //    ClientSecrets = new List<Secret>
                //    {
                //        new Secret("F621F470-9731-4A25-80EF-67A6F7C5F4B8".Sha256())
                //    },

                //    AllowedScopes = new List<string>
                //    {
                //        "AppName_API"
                //    }
                //},

                // human is involved
                new Client
                {
                    ClientName = "AppName API Client",
                    ClientId = "AppName_APIClient",
                    Enabled = true,
                    AccessTokenType = AccessTokenType.Reference,

                    Flow = Flows.ResourceOwner,

                    ClientSecrets = new List<Secret>
                    {
                        new Secret("21B5F798-BE55-42BC-8AA8-0025B903DC3B".Sha256())
                    },

                    AllowedScopes = new List<string>
                    {
                        "AppName_API"
                    }
                }
            };
        }
    }
}
