using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodgersFanSite.Models
{
    public interface IStoryRepository
    {
        List<Story> Stories { get; }
        void AddStory(Story story);
        Story GetUserStoryByTitle(string title);
    }
}
