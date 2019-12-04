﻿using System;
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

        public Story GetUserStoryByTitle(string title)
        {
            Story story = stories.Find(s => s.Title == title);
            return story;
        }
    }
}