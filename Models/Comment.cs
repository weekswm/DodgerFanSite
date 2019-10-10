using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    public class Comment
    {
        public string CommentText { get; set; }
        public User UserName { get; set; }
        public Story UserStory { get; set; }
    }
}
