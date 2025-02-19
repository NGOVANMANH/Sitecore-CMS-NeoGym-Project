using System.Collections.Generic;
using System.Linq;
using MySite.Feature.PageContent.Models;
using Sitecore.Data.Fields;
using Sitecore.Data.Items;
using Sitecore.Links;
using Sitecore.Mvc.Presentation;
using Sitecore.Resources.Media;
using MySite.Foundation.ORM.Models;
using Glass.Mapper.Sc.Web;

namespace MySite.Feature.PageContent.Repositories
{
    public class PageContentRepository : IPageContentRepository
    {
        private readonly IRequestContext _requestContext;

        public PageContentRepository(IRequestContext requestContext)
        {
            _requestContext = requestContext;
        }
        public IEnumerable<IInformationItem> GetInformations()
        {
            var informationFolder = _requestContext.SitecoreService.GetItem<IInformationFolder>(Constants.InformationFolderDataSource.ToGuid());

            if(informationFolder == null)
            {
                return new List<IInformationItem>();
            }

            return informationFolder.InformationItems;
        }

        public IEnumerable<IWhyItem> GetWhyItems()
        {
            #region
            //var datasource = RenderingContext.Current?.Rendering?.Item;
            //var whyItems = new List<WhyItemModel>();
            //if (datasource == null) return whyItems;
            //datasource.Children.ToList().ForEach(item =>
            //{
            //    var iconField = (ImageField)item.Fields[Templates.Why.Fields.Icon];
            //    var iconUrl = string.Empty;
            //    if (iconField != null && iconField.MediaItem != null)
            //    {
            //        var mediaItem = (MediaItem)iconField.MediaItem;
            //        iconUrl = Sitecore.StringUtil.EnsurePrefix('/', MediaManager.GetMediaUrl(mediaItem));
            //    }

            //    whyItems.Add(new WhyItemModel
            //    {
            //        Title = item[Templates.Why.Fields.Title],
            //        Description = item[Templates.Why.Fields.Description],
            //        IconUrl = iconUrl
            //    });
            //});
            #endregion
            
            var whyFolder = _requestContext.SitecoreService.GetItem<IWhyFolder>(Constants.WhyFolderDataSource.ToGuid());

            if (whyFolder == null) return new List<IWhyItem>();

            return whyFolder.WhyItems;
        }
        public IEnumerable<ITrainerItem> GetTrainers()
        {
            var trainerFolder = _requestContext.SitecoreService.GetItem<ITrainerFolder>(Constants.TrainerFolderDataSource.ToGuid());

            if(trainerFolder == null)
            {
                return new List<ITrainerItem>();
            }

            return trainerFolder.Trainers;
        }
    }
}