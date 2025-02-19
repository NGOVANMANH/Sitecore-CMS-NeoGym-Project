using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Results;
using System.Web.Mvc;
using Newtonsoft.Json;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.Mvc.Controllers;

namespace MySite.Feature.Search.Controllers
{
    public class SearchController : SitecoreController
    {
        public ActionResult Query(string keyword)
        {
            var rootItem = Sitecore.Context.Database.GetItem(Sitecore.Context.Site.StartPath);
            var index = ContentSearchManager.GetIndex("sitecore_web_index");

            var results = new List<SearchResultItem>();

            using (var context = index.CreateSearchContext()) 
            {
                results = context.GetQueryable<SearchResultItem>()
                    .Where(i => i.Name.Contains(keyword) || i.Content.Contains(keyword))
                    .ToList();
            }

            return Content(JsonConvert.SerializeObject(results, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }), "application/json");
        }
    }
}