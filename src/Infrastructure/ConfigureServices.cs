using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigureServices
    {
        public static void AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabase(configuration);
            services.AddServices();
        }

        private static void AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {

        }

        private static void AddServices(this IServiceCollection services)
        {

        }
    }
}
