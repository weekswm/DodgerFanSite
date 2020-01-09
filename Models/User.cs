using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DodgersFanSite.Models
{
    public class User
    {
        private List<Comment> comments = new List<Comment>();

        public int UserID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        // These are "navigational properties" that will cause
        // EF to generate FK field for UserID in the Comments table.
        public List<Comment> Comments { get { return comments; } }

    }
}
