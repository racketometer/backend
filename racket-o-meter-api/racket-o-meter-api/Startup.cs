using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(racket_o_meter_api.Startup))]

namespace racket_o_meter_api
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
