using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySite.Feature.Navigation.Models;

namespace MySite.Feature.Navigation.Repositories
{
    public interface INavigationRepository
    {
        IEnumerable<NavigationModel> GetNavigation();
    }
}
