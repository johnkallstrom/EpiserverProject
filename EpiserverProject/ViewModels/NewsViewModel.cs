using EpiserverProject.Models.Pages;
using System.Collections.Generic;

namespace EpiserverProject.ViewModels
{
    public class NewsViewModel
    {
        public IEnumerable<NewsPage> News { get; set; }
    }
}