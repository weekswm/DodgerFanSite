
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DodgersFanSite.Models;
using System.Web;

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
            stories.Sort((s1, s2) => string.Compare(s1.Title, s2.Title, StringComparison.Ordinal));
            foreach (Story story in stories)
                ViewBag.TotalComments = story.Comments.Count();
            return View(stories);
        }

        public IActionResult AddStory()
        {
            return View();
        }

        [HttpPost]
        public RedirectToActionResult AddStory(string title,
                                              string storyTeller, 
                                              string storyText)
        {
            story = new Story
            {
                Title = title,
                StoryTeller = new User
                {
                    Name = storyTeller
                },
                StoryText = storyText
            };
            StoryRepository.AddStory(story);  // this is temporary, in the future the data will go in a database
            return RedirectToAction("ViewStories");
        }

        public IActionResult AddComment(string title)
        {
            return View("AddComment", HttpUtility.HtmlDecode(title));
        }

        [HttpPost]
        public RedirectToActionResult AddComment(string title,
                                                string commentText,
                                                string commenter)
        {
            Story story = StoryRepository.GetUserStoryByTitle(title);
            story.Comments.Add(new Comment()
            {
                Commenter = new User() { Name = commenter },
                CommentText = commentText
            });

            return RedirectToAction("ViewStories");
        }
    }
}