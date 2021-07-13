using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3D.Test.App.StartUp.ConfigureDI
{
    public class AConfigureServices : IConfigureServices
    {
        public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {

        }
    }
}
