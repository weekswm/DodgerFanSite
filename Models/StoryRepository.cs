﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    // This class is temporary and just for testing.
    // Ultimately, data will be stored in a database
    public class StoryRepository : IStoryRepository
    {
        private AppDbContext context;
        public List<Story> Stories { get { return context.Stories.Include("Comments").ToList(); } }

        public StoryRepository(AppDbContext appDbContext)
        {
            context = appDbContext;
        }
        public void AddStory(Story story)
        {
            context.Stories.Add(story);
            context.SaveChanges();
        }

        public Story GetUserStoryByTitle(string title)
        {
            Story story;
            story = context.Stories.First(s => s.Title == title);
            return story;
        }

        public void AddComment(Story story, Comment comment)
        {
            story.Comments.Add(comment);
            context.Stories.Update(story);
            context.SaveChanges();
        }
    }
}

