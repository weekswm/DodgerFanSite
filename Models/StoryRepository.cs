using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    // This class is temporary and just for testing.
    // Ultimately, data will be stored in a database
    public class StoryRepository : IStoryRepository
    {
        private static List<Story> stories = new List<Story>();

        public List<Story> Stories { get { return stories; } }

        public StoryRepository()
        {
            if (stories.Count == 0)
            {
                AddSeedData();
            }
        }
        public void AddStory(Story story)
        {
            stories.Add(story);
        }

        public Story GetUserStoryByTitle(string title)
        {
            Story story = stories.Find(s => s.Title == title);
            return story;
        }

        void AddSeedData()
        {
            Story story = new Story()
            {
                Title = "1988 World Series, game 1",
                StoryTeller = new User()
                {
                    Name = "Vin Scully",
                    Email = "dodger4life@dodgers.com"
                },
                StoryText = "Eckersley was on the mound..."
            };
            stories.Add(story);
        }
    }
}

