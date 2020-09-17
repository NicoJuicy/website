﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ClientService
{
    internal static class WebHostEnvironmentExtensions
    {
        internal static bool IsFrontendDevelopment(this IWebHostEnvironment env)
            => env.IsEnvironment("FrontendDevelopment");
    }
}