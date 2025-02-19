using Microsoft.Extensions.DependencyInjection;
using MySite.Feature.Navigation.Controllers;
using MySite.Feature.Navigation.Repositories;
using Sitecore.DependencyInjection;

namespace MySite.Feature.Navigation.ServicesConfigurators
{
    public class DependenciesRegistration : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<NavigationController>();
            serviceCollection.AddTransient<INavigationRepository, NavigationRepository>();
        }
    }
}