using System;
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
            public static string Arcadia() { return "Arcadia"; }
            public static string Auth() { return "Auth"; }
            public static string Billing() { return "Billing"; }
            public static string Telecaster() { return "Telecaster"; }
        }

        public static void Config()
        {
            IServiceCollection service = new ServiceCollection();

            service.AddDbContext<ArcadiaContext>(opt =>
            {
                opt.UseSqlServer($"Server=LOCALHOST; Database={DatabaseName.Auth()};User Id=sa;Password=;");
            });
        }

        public static void ConfigureContext(ArcadiaContext rpContext)
        {
            
            //rpContext.;
        }
    }
}
