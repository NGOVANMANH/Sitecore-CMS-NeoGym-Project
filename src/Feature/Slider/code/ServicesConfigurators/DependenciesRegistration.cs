using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Extensions.DependencyInjection;
using MySite.Feature.Slider.Controllers;
using MySite.Feature.Slider.Repositories;
using Sitecore.DependencyInjection;
using Sitecore.Diagnostics;

namespace MySite.Feature.Slider.ServicesConfigurators
{
    public class DependenciesRegistration : IServicesConfigurator
    {
        public void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<SliderController>();
            serviceCollection.AddTransient<ISliderRepository, SliderRepository>();
        }
    }
}