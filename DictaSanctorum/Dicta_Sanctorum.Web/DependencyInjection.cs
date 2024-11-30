using Dicta_Sanctorum.Data.InterfacesRepository;
using Dicta_Sanctorum.Data.Repository;

namespace Dicta_Sanctorum
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInjections(this IServiceCollection services)
        {
            services.AddTransient<IPhraseRepository, PhraseRepository>();
            services.AddTransient<ISaintRepository, SaintsRepository>();
            return services;
        }
    }
    
}
