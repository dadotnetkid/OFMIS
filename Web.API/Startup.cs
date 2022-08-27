﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Models.Startups;
using Owin;

[assembly: OwinStartup(typeof(Web.API.Startup))]

namespace Web.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Authentication.ConfigureAuth(app);
        }
    }
}