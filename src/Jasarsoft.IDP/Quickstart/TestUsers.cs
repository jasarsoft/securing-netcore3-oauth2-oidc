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
        public static List<TestUser> Users =>
            new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1994F4F5-B590-4572-B04A-00DB0004394B",
                    Username = "Frank",
                    Password = "password",
                    Claims =
                    {
                        new Claim("given_name", "Frank"),
                        new Claim("family_name", "Underwood")
                    }
                },
                new TestUser
                {
                    SubjectId = "D144154B-AF38-4A0C-A261-31D756F88364",
                    Username = "Claire",
                    Password = "password",
                    Claims =
                    {
                        new Claim("given_name", "Claire"),
                        new Claim("family_name", "Underwood")
                    }
                }
            };
    }
}