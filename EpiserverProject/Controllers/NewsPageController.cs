using System.Web.Mvc;
using EpiserverProject.Models.Pages;
using EpiserverProject.ViewModels;

namespace EpiserverProject.Controllers
{
    public class NewsPageController : PageControllerBase<NewsPage>
    {
        public ActionResult Index(NewsPage currentPage)
        {
            var model = new NewsPageViewModel(currentPage);

            return View(model);
        }
    }
}