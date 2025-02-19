using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using MySite.Foundation.ORM.Models;

namespace MySite.Feature.PageContent.Models
{
    [SitecoreType(AutoMap = true)]
    public interface ISocialLinkItem : ISitecoreItem
    {
        [SitecoreField(Templates.SocialLink.Fields.Platform)]
        string PlatformName { get; set; }

        [SitecoreField(Templates.SocialLink.Fields.Url)]
        Link CtaUrl { get; set; }

        [SitecoreField(Templates.SocialLink.Fields.Icon)]
        Image Icon { get; set; }
    }
}