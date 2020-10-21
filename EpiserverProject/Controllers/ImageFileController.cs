using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;
using EpiserverProject.Models.Media;
using EpiserverProject.ViewModels;
using System.Web.Mvc;

namespace EpiserverProject.Controllers
{
    public class ImageFileController : PartialContentController<ImageFile>
    {
        private readonly UrlResolver _urlResolver;

        public ImageFileController(UrlResolver urlResolver)
        {
            _urlResolver = urlResolver;
        }

        public override ActionResult Index(ImageFile currentContent)
        {
            var model = new ImageViewModel
            {
                Url = _urlResolver.GetUrl(currentContent.ContentLink),
                Name = currentContent.Name,
                Copyright = currentContent.Copyright
            };

            return PartialView(model);
        }
    }
}