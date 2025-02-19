using Sitecore.Pipelines;
using System.Web.Mvc;
using System.Web.Routing;

namespace MySite.Feature.PageContent.Pipelines.Initialize
{
    public class RegisterWebApiRoutes
    {
        public virtual void Process(PipelineArgs args)
        {
            RouteTable.Routes.MapRoute(
                name: "MySite.Feature.PageContent.Api",
                url: $"mysite/api/contact/{{action}}/{{id}}",
                defaults: new { controller = "ContactApi" , id = UrlParameter.Optional },
                namespaces: new[] { $"MySite.Feature.PageContent.Controllers" }
            );
        }
    }
}