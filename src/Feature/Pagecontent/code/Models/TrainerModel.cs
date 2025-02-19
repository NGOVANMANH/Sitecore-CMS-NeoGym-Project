using System.Collections.Generic;

namespace MySite.Feature.PageContent.Models
{
    public class TrainerModel
    {
        public string Name { get; set; }
        public string TrainerThumbnailUrl { get; set; }
        public List<SocialUrl> SocialUrls { get; set; }
    }

    public class SocialUrl
    {
        public string Platform { get; set; }
        public string Url { get; set; }
        public string IconUrl { get; set; }
    }
}