using Sitecore.Pipelines;
using System.Web.Mvc;
using System.Web.Routing;

namespace MySite.Feature.Search.Pipelines.Initialize
{
    public class RegisterWebApiRoutes
    {
        public virtual void Process(PipelineArgs args)
        {
            RouteTable.Routes.MapRoute(
                name: "MySite.Feature.Search.Api",
                url: $"mysite/api/feature/search/{{action}}/{{id}}",
                defaults: new { controller = "Search" , id = UrlParameter.Optional },
                namespaces: new[] { $"MySite.Feature.Search.Controllers" }
            );
        }
    }
}