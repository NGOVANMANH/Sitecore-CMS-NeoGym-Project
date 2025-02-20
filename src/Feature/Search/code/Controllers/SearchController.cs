using System.Web.Mvc;
using MySite.Feature.Search.Repositories;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Sitecore.Mvc.Controllers;

namespace MySite.Feature.Search.Controllers
{
    public class SearchController : SitecoreController
    {
        private readonly ISearchRepository _searchRepository;

        public SearchController(ISearchRepository searchRepository)
        {
            _searchRepository = searchRepository;
        }

        [HttpGet]
        public ActionResult Query(string keyword, int page=1, int pageSize=5)
        {
            if (page < 1) page = 1;
            if (pageSize < 1) pageSize = 5;

            var results = _searchRepository.Search(keyword, page, pageSize);

            return Content(
                JsonConvert.SerializeObject(
                    results
                    , new JsonSerializerSettings
                    {
                        ContractResolver = new DefaultContractResolver
                        {
                            NamingStrategy = new CamelCaseNamingStrategy()
                        },
                        Formatting = Formatting.Indented,
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                    }),
                "application/json");
        }
    }
}