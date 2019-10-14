﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DodgersFanSite.Models;

namespace DodgersFanSite.Controllers
{
    public class StoryController : Controller
    {
        Story story;
        public StoryController()
        {
            // This is temporary code, just for testing
            if (StoryRepository.Stories.Count == 0)  // only do this if it hasn't been done already
            {
                story = new Story()
                {
                    Title = "1988 World Series, game 1",
                    StoryTeller = new User()
                    {
                        Name = "Vin Scully",
                        Email = "dodger4life@dodgers.com"
                    },
                    StoryText = "Eckersley was on the mound..."
                };
                StoryRepository.AddStory(story);
            }
        }

        public IActionResult ViewStories()
        {
            List<Story> stories = StoryRepository.Stories;
            return View();
        }

        public IActionResult AddStory()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddStory(string title,
                                              User storyTeller, 
                                              string storyText)
        {
            story = new Story();
            story.Title = title;
            story.StoryTeller = storyTeller;
            story.StoryText = storyText;
            StoryRepository.AddStory(story);  // this is temporary, in the future the data will go in a database

            return RedirectToAction("ViewStories");
        }
    }
}