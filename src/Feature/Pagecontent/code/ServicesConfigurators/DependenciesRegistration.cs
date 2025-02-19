using Microsoft.Extensions.DependencyInjection;
using MySite.Feature.PageContent.Controllers;
using MySite.Feature.PageContent.Repositories;
using Sitecore.DependencyInjection;

namespace MySite.Feature.PageContent.ServicesConfigurators
{
    public class DependenciesRegistration : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<PageContentController>();
            serviceCollection.AddTransient<IPageContentRepository, PageContentRepository>();
            serviceCollection.AddTransient<ContactApiController>();
        }
    }
}