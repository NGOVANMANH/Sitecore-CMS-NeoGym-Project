using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySite.Feature.Slider.Models;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;

namespace MySite.Feature.Slider.Repositories
{
    public class SliderRepository : ISliderRepository
    {
        public IEnumerable<SliderModel> GetSliders()
        {
            var currentItem = RenderingContext.Current?.Rendering?.Item;
            if (currentItem == null) return new List<SliderModel>();

            return currentItem.Children
                .Select(item => new SliderModel
                {
                    Title = item.Fields[Templates.Slide.Fields.Title]?.Value ?? string.Empty,
                    Subtitle = item.Fields[Templates.Slide.Fields.Subtitle]?.Value ?? string.Empty,
                    MainTitle = item.Fields[Templates.Slide.Fields.MainTitle]?.Value ?? string.Empty,
                    Description = item.Fields[Templates.Slide.Fields.Description]?.Value ?? string.Empty,
                    CTA_Link = ((Sitecore.Data.Fields.LinkField)item.Fields[Templates.Slide.Fields.CTA_Link])?.GetFriendlyUrl() ?? "#"
                })
                .ToList();
        }
    }
}