// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using IdentityServer4;

namespace IdentityServerHost.Quickstart.UI
{
    public class TestUsers
    {
        public static List<TestUser> Users
        {
            get
            {
                return new List<TestUser>
                {
                    new TestUser
                    {
                        SubjectId = "818727",
                        Username = "Alice",
                        Password = "pass",
                        Claims =
                        {
                            new Claim("first_name", "Alice"),
                            new Claim("last_name", "Smith"),
                            new Claim("email", "AliceSmith@email.com"),
                        }
                    },
                    new TestUser
                    {
                        SubjectId = "88421113",
                        Username = "Bob",
                        Password = "pass",
                        Claims =
                        {
                            new Claim("first_name", "Bob"),
                            new Claim("last_name", "Smith"),
                            new Claim("email", "BobSmith@email.com"),
                        }
                    }
                };
            }
        }
    }
}