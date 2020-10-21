using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using EpiserverProject.Models.Blocks;
using EpiserverProject.Models.Containers;
using EpiserverProject.Models.Pages;
using EpiserverProject.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EpiserverProject.Controllers
{
    public class NewsBlockController : BlockController<NewsBlock>
    {
        private readonly IContentLoader _contentLoader;

        public NewsBlockController(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public override ActionResult Index(NewsBlock currentBlock)
        {
            NewsContainer newsContainer = null;

            if (!ContentReference.IsNullOrEmpty(currentBlock.NewsContainer))
            {
                newsContainer = _contentLoader.Get<NewsContainer>(currentBlock.NewsContainer);
            }

            var model = new NewsViewModel
            {
                News = GetNews(newsContainer)
            };

            return PartialView(model);
        }

        private IEnumerable<NewsPage> GetNews(NewsContainer newsContainer)
        {
            return _contentLoader.GetChildren<NewsPage>(newsContainer.ContentLink);
        }
    }
}