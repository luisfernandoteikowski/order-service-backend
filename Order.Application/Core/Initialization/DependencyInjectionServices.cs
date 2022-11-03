using Microsoft.Extensions.DependencyInjection;
using OrderService.Extensisons;

namespace Order.Application.Core.Initialization
{
    public static class DependencyInjectionServices
    {
        public static void AddApplicationDependencies(this IServiceCollection services)
        {
            services.AddFacades();
        }

        private static void AddFacades(this IServiceCollection services)
        {
            services.AddImplementations(ServiceLifetime.Transient, typeof(IBaseFacade));
        }
    }
}
