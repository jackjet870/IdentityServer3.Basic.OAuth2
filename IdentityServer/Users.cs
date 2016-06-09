using IdentityServer3.Core.Services.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer
{
    static class Users
    {
        public static List<InMemoryUser> Get()
        {
            return new List<InMemoryUser>
            {
                new InMemoryUser
                {
                    Username = "Bob",
                    Password = "WhoAteMyCake",
                    Subject = "1"
                },
                new InMemoryUser
                {
                    Username = "Alice",
                    Password = "somePassword",
                    Subject = "2"
                },
                new InMemoryUser
                {
                    Username = "Jake",
                    Password = "IamBigD",
                    Subject = "3"
                }
            };
        }
    }
}
