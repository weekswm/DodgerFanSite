using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    public class User
    {
        
        private List<Story> stories = new List<Story>();
        private List<Comment> comments = new List<Comment>();

        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Story> Stories { get { return stories; } }
        public List<Comment> Comments { get { return comments; } }

    }
}
