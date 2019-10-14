using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    public class Story
    {
        public string Title { get; set; }
        public User StoryTeller { get; set; }
        public string StoryText { get; set; }
    }
}
