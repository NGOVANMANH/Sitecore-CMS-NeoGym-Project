using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySite.Feature.Slider.Models;

namespace MySite.Feature.Slider.Repositories
{
    public interface ISliderRepository
    {
        IEnumerable<SliderModel> GetSliders();
    }
}
