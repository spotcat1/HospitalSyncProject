using Application.Services.Implementation;
using Application.Services.Interface;
using Microsoft.Extensions.DependencyInjection;


namespace Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddScoped<IUser, UserImplementation>();

            return services;
        }
    }
}
