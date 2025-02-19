using Microsoft.Extensions.DependencyInjection;
using MySite.Foundation.Email.Services;
using Sitecore.DependencyInjection;

namespace MySite.Foundation.Email.ServicesConfigurators
{
    public class DependenciesRegistration : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IEmailService, EmailService>();
        }
    }
}