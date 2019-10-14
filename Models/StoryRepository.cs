using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    // This class is temporary and just for testing.
    // Ultimately, data will be stored in a database
    public static class StoryRepository
    {
        private static List<Story> stories = new List<Story>();

        public static List<Story> Stories { get { return stories; } }
        public static void AddStory(Story story)
        {
            stories.Add(story);
        }
    }
}
