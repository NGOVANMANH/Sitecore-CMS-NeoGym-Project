using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;

namespace MySite.Feature.PageContent.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IWhyItem
    {
        [SitecoreField(Templates.Why.Fields.Title)]
        string Title { get; set; }

        [SitecoreField(Templates.Why.Fields.Description)]
        string Description { get; set; }

        [SitecoreField(Templates.Why.Fields.Icon)]
        Image Icon { get; set; }
    }
}