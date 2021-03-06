﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RappelzCore.Data
{
    public class RappelzConfiguration
    {
        public static class DatabaseName
        {
            public static string Arcadia => "Arcadia";
            public static string Auth => "Auth";
            public static string Billing => "Billing";
            public static string Telecaster => "Telecaster";
        }

        public static void Config()
        {
            IServiceCollection service = new ServiceCollection();

            service.AddDbContext<ArcadiaContext>(opt =>
            {
                opt.UseSqlServer($"Server=LOCALHOST; Database={DatabaseName.Auth};User Id=sa;Password=;");
            });
        }

        public static void ConfigureContext(ArcadiaContext rpContext)
        {
            
            //rpContext.;
        }
    }
}
