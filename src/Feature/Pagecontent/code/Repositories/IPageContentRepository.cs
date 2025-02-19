using System.Collections.Generic;
using MySite.Feature.PageContent.Models;

namespace MySite.Feature.PageContent.Repositories
{
    public interface IPageContentRepository
    {
        IEnumerable<IInformationItem> GetInformations();
        IEnumerable<ITrainerItem> GetTrainers();
        IEnumerable<IWhyItem> GetWhyItems();
    }
}