using EpiserverProject.Models;
using System.Collections.Generic;

namespace EpiserverProject.ViewModels
{
    public class RssViewModel
    {
        public IEnumerable<RssFeed> Feed { get; set; }
    }
}