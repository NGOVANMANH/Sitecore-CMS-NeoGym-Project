using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySite.Feature.Navigation.Models;
using Sitecore.Links;
using Sitecore.Mvc.Presentation;

namespace MySite.Feature.Navigation.Repositories
{
    public class NavigationRepository : INavigationRepository
    {
        public IEnumerable<NavigationModel> GetNavigation()
        {
            var navigationItems = new List<NavigationModel>();
            var dataSource = RenderingContext.Current.Rendering.Item;

            if (dataSource == null) return navigationItems;

            var homeItem = Sitecore.Context.Database.GetItem(Constants.RootId);

            if (homeItem != null)
            {
                navigationItems.Add(new NavigationModel
                {
                    DisplayName = Constants.Home,
                    Url = LinkManager.GetItemUrl(homeItem),
                    IsActive = Sitecore.Context.Item.ID == homeItem.ID
                });
            }

            dataSource.Children.ToList().ForEach(item =>
            {
                var navUrl = item.Fields[Templates.Navigation.Fields.Url]?.Value ?? string.Empty;

                var navPath = LinkManager.GetItemUrl(item);

                navigationItems.Add(new NavigationModel
                {
                    DisplayName = item.Fields[Templates.Navigation.Fields.Title]?.Value ?? string.Empty,
                    Url = navPath,
                    IsActive = Sitecore.Context.Item.ID == item.ID
                });
            });

            return navigationItems;
        }
    }
}