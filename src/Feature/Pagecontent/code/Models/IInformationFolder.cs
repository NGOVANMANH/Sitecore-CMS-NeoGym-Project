using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace MySite.Feature.PageContent.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IInformationFolder
    {
        [SitecoreChildren]
        IEnumerable<IInformationItem> InformationItems { get; set; }
    }
}