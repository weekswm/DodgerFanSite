using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; }

        // EF will generate a FK field, CommenterUserID, in the Comment table.
        public User Commenter { get; set; }

        // EF will generate a FK field, StoryCommentStoryID, in the Comment table.
        public Story StoryComment { get; set; }
        public object ViewBag { get; }
    }
}
