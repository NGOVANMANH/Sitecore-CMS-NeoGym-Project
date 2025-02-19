using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.ContentSearch;
using Sitecore.Data;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;

namespace MySite.Foundation.ORM.Models
{
    public class SitecoreItem : ISitecoreItem
    {
        [SitecoreItem]
        public virtual Item ScItem { get; set; }

        [SitecoreId, IndexField("_group")]
        public virtual ID ID { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId), IndexField("_template")]
        public virtual Guid TemplateID { get; set; }

        [SitecoreField("__Sortorder"), IndexField("__Sortorder")]
        public virtual string SortOrder { get; set; }

        [SitecoreField("__updated"), IndexField("__updated")]
        public virtual DateTime ModifiedDate { get; set; }

        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        public virtual string DisplayName { get; set; }

            [SitecoreInfo(SitecoreInfoType.Url,
            UrlOptions = SitecoreInfoUrlOptions.AlwaysIncludeServerUrl | SitecoreInfoUrlOptions.LanguageEmbeddingNever)]
        public virtual string FullUrl { get; set; }

        [SitecoreChildren(InferType = true)]
        public virtual IEnumerable<ISitecoreItem> Children { get; set; }

        [IndexField("_latestversion")]
        public virtual bool IsLatestVersion { get; set; }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TemplateName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Path { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Url { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
