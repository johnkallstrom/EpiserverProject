using System.Linq;
using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EpiserverProject.Models.Blocks;
using EpiserverProject.Services;
using EpiserverProject.ViewModels;

namespace EpiserverProject.Controllers
{
    public class RssBlockController : BlockController<RssBlock>
    {
        private readonly IRssFeedService _rssFeedService;

        public RssBlockController(IRssFeedService rssFeedService)
        {
            _rssFeedService = rssFeedService;
        }

        public override ActionResult Index(RssBlock currentBlock)
        {
            var model = new RssViewModel
            {
                Feed = _rssFeedService.ReadFeed("http://feeds.bbci.co.uk/news/rss.xml").ToList()
            };

            return PartialView(model);
        }
    }
}
