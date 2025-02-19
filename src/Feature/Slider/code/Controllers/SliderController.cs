using System.Web.Mvc;
using MySite.Feature.Slider.Repositories;


namespace MySite.Feature.Slider.Controllers
{
    public class SliderController : Controller
    {
        private readonly ISliderRepository _sliderRepository;

        public SliderController(ISliderRepository sliderRepository)
        {
            _sliderRepository = sliderRepository;
        }
        public ActionResult RenderSlider()
        {
            var slides = _sliderRepository.GetSliders();
            return View("~/Views/MySite/Slider/Slider.cshtml", slides);
        }
    }
}