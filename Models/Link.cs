using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    public class Link
    {
        private List<Link> links = new List<Link>();

        public string Website { get; set; }
        public string Desc { get; set; }

        public List<Link> Links { get { return links; } }
    }
}
