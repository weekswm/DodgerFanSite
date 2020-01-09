using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DodgersFanSite.Models
{
    public class Story
    {
        public int StoryID { get; set; }
        private List<Comment> comments = new List<Comment>();

        public string Title { get; set; }

        public string StoryText { get; set; }

        // EF will generate a FK field, StoryTellerUserID, in the Story table.
        public User StoryTeller { get; set; }

        //EF to create FK fields for StoryID in Comments table.
        public List<Comment> Comments { get { return comments; } }
    }
}
