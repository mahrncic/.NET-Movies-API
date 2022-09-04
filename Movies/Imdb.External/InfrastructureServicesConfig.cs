using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Movies.Application.Contracts;

namespace DataProvider.External
{
    public static class InfrastructureServicesConfig
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IMovieProvider, MovieProvider>();

            return services;
        }
    }
}
