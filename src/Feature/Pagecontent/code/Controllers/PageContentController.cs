using System.Web.Mvc;
using MySite.Feature.PageContent.Repositories;


namespace MySite.Feature.PageContent.Controllers
{
    public class PageContentController : Controller
    {
        private readonly IPageContentRepository _pageContentRepository;

        public PageContentController(IPageContentRepository pageContentRepository)
        {
            _pageContentRepository = pageContentRepository;
        }
        public ActionResult RenderInformation()
        {
            var informations = _pageContentRepository.GetInformations();

            return View("~/Views/MySite/PageContent/Information.cshtml", informations);
        }

        public ActionResult RenderWhy()
        {
            var whyItems = _pageContentRepository.GetWhyItems();

            return View("~/Views/MySite/PageContent/Why.cshtml", whyItems);
        }

        public ActionResult RenderTrainers()
        {
            var trainers = _pageContentRepository.GetTrainers();

            return View("~/Views/MySite/PageContent/Trainers.cshtml", trainers);
        }
    }
}