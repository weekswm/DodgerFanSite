using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    public class SeedData
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Stories.Any())
            {
                User user = new User { Name = "Vin Scully" };
                context.Users.Add(user);

                Comment comment = new Comment
                {
                    CommentText = "Great game, an amazing piece of Dodger baseball!",
                    Commenter = user
                };
                context.Comments.Add(comment);

                Story story = new Story
                {
                    Title = "1988 World Series, game 1",
                    StoryText = "Eckersley was on the mound..."
                };
                story.Comments.Add(comment);
                context.Stories.Add(story);

                context.SaveChanges(); // save all the data
            }
        }
    }
}

