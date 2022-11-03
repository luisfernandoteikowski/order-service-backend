using Microsoft.Extensions.DependencyInjection;
using OrderService.Extensisons;

namespace OrderService.Domain.Services.Core.Initialization
{
    public static class DependencyInjectionServices
    {

        public static void AddDomainServicesDependencies(this IServiceCollection services)
        {
            services.AddServices();
            services.AddValidators();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services.AddImplementations(ServiceLifetime.Transient, typeof(IBaseService));
        }

        private static void AddValidators(this IServiceCollection services)
        {
            services.AddImplementations(ServiceLifetime.Transient, typeof(IBaseValidator));
        }
    }
}
