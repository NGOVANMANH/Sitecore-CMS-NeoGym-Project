using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using MySite.Foundation.ORM.Models;

namespace MySite.Feature.PageContent.Models
{
    [SitecoreType(AutoMap = true)]
    public interface ITrainerItem : ISitecoreItem
    {
        [SitecoreField(Templates.Trainer.Fields.Name)]
        string TrainerName { set; get; }

        [SitecoreField(Templates.Trainer.Fields.Thumbnail)]
        Image TrainerThumbnail { set; get; }

        [SitecoreChildren]
        IEnumerable<ISocialLinkItem> SocialUrls { set; get; }
    }
}