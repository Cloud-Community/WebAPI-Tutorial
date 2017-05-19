/// <summary>
/// WebAPI-Tutorial
/// https://github.com/ajmaltahir/WebAPI-Tutorial
/// 
/// Created by Ajmal Tahir
/// Copyright © 2017 Ajmal Tahir. All rights reserved.
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(App.WebAPI.Startup))]

namespace App.WebAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
