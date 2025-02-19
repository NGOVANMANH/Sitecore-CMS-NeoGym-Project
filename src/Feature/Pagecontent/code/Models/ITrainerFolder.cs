using System.Collections.Generic;
using Glass.Mapper.Sc.Configuration.Attributes;

namespace MySite.Feature.PageContent.Models
{
    [SitecoreType(AutoMap = true)]
    public interface ITrainerFolder
    {
        [SitecoreChildren]
        IEnumerable<ITrainerItem> Trainers { get; set; }
    }
}