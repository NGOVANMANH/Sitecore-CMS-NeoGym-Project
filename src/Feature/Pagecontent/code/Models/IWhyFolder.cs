using System.Collections;
using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace MySite.Feature.PageContent.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IWhyFolder
    {
        [SitecoreChildren]
        IEnumerable<IWhyItem> WhyItems { get; set; }
    }
}