using System.Web.Mvc;
using MySite.Feature.Navigation.Repositories;
using Sitecore.Mvc.Controllers;

namespace MySite.Feature.Navigation.Controllers
{
    public class NavigationController : SitecoreController
    {
        private readonly INavigationRepository _navigationRepository;

        public NavigationController(INavigationRepository navigationRepository)
        {
            _navigationRepository = navigationRepository;
        }
        public ActionResult RenderHeader()
        {
            var navigationItems = _navigationRepository.GetNavigation();
            return View("~/Views/Mysite/Navigation/Header.cshtml", navigationItems);
        }

        public ActionResult RenderFooter() {
            return View("~/Views/Mysite/Navigation/Footer.cshtml");
        }
    }
}                                                                                                                       