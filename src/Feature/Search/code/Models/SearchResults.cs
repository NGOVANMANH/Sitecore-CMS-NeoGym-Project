using System.Collections.Generic;
using Sitecore.ContentSearch.SearchTypes;

namespace MySite.Feature.Search.Models
{
    public class SearchResults
    {
        public IEnumerable<SearchResultItem> ResultItems { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalResults { get; set; }
        public SearchResults() => ResultItems = new List<SearchResultItem>();
    }
}