using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DodgersFanSite.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string CommentText { get; set; }

        [Required]
        // EF will generate a FK field, CommenterUserID, in the Comment table.
        public User Commenter { get; set; }

        public object ViewBag { get; }
    }
}
