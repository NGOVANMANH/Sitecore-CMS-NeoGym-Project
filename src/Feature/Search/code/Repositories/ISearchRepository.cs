using System.Collections.Generic;
using MySite.Feature.Search.Models;

namespace MySite.Feature.Search.Repositories
{
    public interface ISearchRepository
    {
        SearchResults Search(string keyword, int page, int pageSize);
    }
}