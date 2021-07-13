using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _3D.Test.App.StartUp.ConfigureDI
{
    public interface IConfigureServices
    {
        void ConfigureServices(IServiceCollection services, IConfiguration configuration);
    }
}