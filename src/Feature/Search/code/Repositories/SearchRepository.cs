using MySite.Feature.Search.Models;
using Sitecore.ContentSearch;
using Sitecore.ContentSearch.Linq;
using Sitecore.ContentSearch.SearchTypes;
using Sitecore.ContentSearch.Utilities;
using System.Linq;

namespace MySite.Feature.Search.Repositories
{
    public class SearchRepository : ISearchRepository
    {
        public SearchResults Search(string keyword, int page, int pageSize)
        {
            var index = ContentSearchManager.GetIndex("sitecore_master_index");

            var searchResults = new SearchResults();
            using (var context = index.CreateSearchContext())
            {
                // Build the query
                var query = context.GetQueryable<SearchResultItem>()
                    .Where(item => item.Content.Contains(keyword) || item.Name.Contains(keyword))
                    .Where(item => item.TemplateName == "_Trainer"); // Search by keyword in content

                // Apply pagination
                var paginatedResults = query
                    .Skip((page - 1) * pageSize) // Skip items for previous pages
                    .Take(pageSize) // Take items for the current page
                    .GetResults(); // Execute the query and get results

                // Map results to the SearchResults object
                searchResults.ResultItems = paginatedResults.Hits.Select(hit => hit.Document).ToList();
                searchResults.Page = page;
                searchResults.PageSize = pageSize;
                searchResults.TotalResults = paginatedResults.TotalSearchResults;
            }

            return searchResults;
        }
    }
}