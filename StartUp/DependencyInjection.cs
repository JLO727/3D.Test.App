using _3D.Test.App.Data;
using _3D.Test.App.Data.Providers;
using _3D.Test.App.Data.Services;
using _3D.Test.App.StartUp.ConfigureDI;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3D.Test.App.StartUp
{
    public class DependencyInjection
    {
        public static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            if (configuration is IConfigurationRoot)
            {
                services.AddSingleton<IConfigurationRoot>(configuration as IConfigurationRoot);   // IConfigurationRoot
            }

            services.AddSingleton<IConfiguration>(configuration);   // IConfiguration explicitly
                                                                    // ​
            string connString = configuration.GetConnectionString("Default");

            services.AddSingleton<IMessageService, MessageService>();
            services.AddSingleton<_3D.Test.App.Data.Providers.ISqlDataProvider, SqlDataProvider>(delegate (IServiceProvider provider)
            {
                return new SqlDataProvider(connString);
            });




            GetAllEntities().ForEach(tt =>
            {
                IConfigureServices idi = Activator.CreateInstance(tt) as IConfigureServices;

                    //This will not error by way of being null. BUT if the code within the method does
                    // then I'd would rather have the error loadly on startup then worry about debuging the issues as it runs
                    idi.ConfigureServices(services, configuration);
            });
        }

        public static List<Type> GetAllEntities()
        {
            return AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.GetTypes())
                 .Where(x => typeof(IConfigureServices).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract)
                 .ToList();
        }

        public static void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
        }
    }
   }

