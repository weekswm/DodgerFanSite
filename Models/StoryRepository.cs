using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    // This class is temporary and just for testing.
    // Ultimately, data will be stored in a database
    public class StoryRepository : IEnumerable<Story>
    {
        private static List<Story> stories = new List<Story>();

        public static List<Story> Stories { get { return stories; } }
        public static void AddStory(Story story)
        {
            stories.Add(story);
        }

        public IEnumerator<Story> GetEnumerator()
        {
            foreach (Story s in stories)
            {
                yield return s;
            }
        }

        IEnumerator<Story> IEnumerable<Story>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
