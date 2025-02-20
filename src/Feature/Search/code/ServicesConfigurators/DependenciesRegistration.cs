using Microsoft.Extensions.DependencyInjection;
using MySite.Feature.Search.Controllers;
using MySite.Feature.Search.Repositories;
using Sitecore.DependencyInjection;

namespace MySite.Feature.Search.ServicesConfigurators
{
    public class DependenciesRegistration : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<SearchController>();
            serviceCollection.AddTransient<ISearchRepository, SearchRepository>();
        }
    }
}