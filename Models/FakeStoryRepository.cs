using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    public class FakeStoryRepository : IStoryRepository
    {
        private List<Story> stories = new List<Story>();
        public List<Story> Stories { get { return stories; } }

        public void AddStory(Story story)
        {
            stories.Add(story);
        }

        public void AddComment(Story story, Comment comment)
        {
            Story theStory = stories.First<Story>(s => s.StoryID == story.StoryID);
            theStory.Comments.Add(comment);
        }

        public Story GetUserStoryByTitle(string title)
        {
            Story story = stories.Find(s => s.Title == title);
            return story;
        }
    }
}
