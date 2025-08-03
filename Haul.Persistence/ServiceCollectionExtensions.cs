using Haul.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace Haul.Persistence

{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped<IPersistenceService, PersistenceService>();
            return services;
        }
    }
}
