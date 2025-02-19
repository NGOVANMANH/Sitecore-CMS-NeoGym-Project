using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySite.Feature.PageContent.Extensions
{
    public static class UrlFieldExtension
    {
        public static string GetFriendlyUrl(this Sitecore.Data.Fields.LinkField linkField)
        {
            if (linkField == null) return string.Empty;
            if (!string.IsNullOrEmpty(linkField.Url))
            {
                return linkField.Url;
            }
            if (linkField.TargetItem != null)
            {
                return Sitecore.Links.LinkManager.GetItemUrl(linkField.TargetItem);
            }
            return string.Empty;
        }
    }
}