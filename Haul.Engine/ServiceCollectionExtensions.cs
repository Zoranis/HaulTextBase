using Haul.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace Haul.Engine
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEngineServices(this IServiceCollection services)
        {
            services.AddPersistenceServices();
            return services;
        }
    }
}
