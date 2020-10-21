using System.Web.Mvc;
using EpiserverProject.Models.Pages;
using EpiserverProject.ViewModels;

namespace EpiserverProject.Controllers
{
    public class AboutPageController : PageControllerBase<AboutPage>
    {
        public ActionResult Index(AboutPage currentPage)
        {
            var model = new AboutPageViewModel(currentPage);

            return View(model);
        }
    }
}