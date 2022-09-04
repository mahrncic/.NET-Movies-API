using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Movies.Application.Config
{
    public static class ApplicationServicesConfig
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
