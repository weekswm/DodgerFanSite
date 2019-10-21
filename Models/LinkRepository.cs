using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    public class LinkRepository
    {
        private static List<Link> links = new List<Link>();
        public static List<Link> Links { get { return links; } }

        static LinkRepository()
        {
            AddTestData();
        }

        public static void AddLink(Link link)
        {
            links.Add(link);
        }

        public static Link GetLinkByTitle(string siteName)
        {
            Link link = links.Find(l => l.Website == siteName);
            return link;
        }

        static void AddTestData()
        {
            Link link = new Link()
            {
                Website = "https://en.wikipedia.org/wiki/Los_Angeles_Dodgers",
                Desc = "The LA Dodgers Wikipedia Page"
            };
            links.Add(link);

            link = new Link()
            {
                Website = "https://bleacherreport.com/los-angeles-dodgers",
                Desc = "Bleacher Report"
            };

            link = new Link()
            {
                Website = "https://www.dodgersnation.com",
                Desc = "Dodgers Nation"
            };
            links.Add(link);
        }
    }
}
