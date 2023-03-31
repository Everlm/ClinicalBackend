using Clinical.Application.Interfaces.Interfaces;
using Clinical.Persistence.Context;
using Clinical.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Clinical.Persistence.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionPersistence(this IServiceCollection services)
        {
            services.AddSingleton<ApplicationDbContext>();
            services.AddScoped<IAnalysisRepository, AnalysisRepository>();
            return services;
        }
    }
}
