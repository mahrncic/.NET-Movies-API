using DataProvider.External.APIs;
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

            services.AddScoped<ImdbApiService>(x =>
                                ActivatorUtilities.CreateInstance<ImdbApiService>(x, configuration));
            services.AddScoped<YouTubeApiService>(x =>
                                            ActivatorUtilities.CreateInstance<YouTubeApiService>(x, configuration));
            return services;
        }
    }
}
