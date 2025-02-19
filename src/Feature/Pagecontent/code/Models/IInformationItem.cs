using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using MySite.Foundation.ORM.Models;

namespace MySite.Feature.PageContent.Models
{
    [SitecoreType(AutoMap = true)]
    public interface IInformationItem : ISitecoreItem
    {
        [SitecoreField(Templates.Information.Fields.Content)]
        string Content { get; set; }

        [SitecoreField(Templates.Information.Fields.Image)]
        Image Image { get; set; }

        [SitecoreField(Templates.Information.Fields.Url)]
        Link CtaUrl { get; set; }
    }
}