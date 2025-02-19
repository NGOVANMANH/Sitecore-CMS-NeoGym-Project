using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySite.Feature.Navigation.Models
{
    public class NavigationModel
    {
        public string DisplayName { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
    }
}