using System.Web.Mvc;
using EpiserverProject.Models.Pages;
using EpiserverProject.ViewModels;

namespace EpiserverProject.Controllers
{
    public class EpiserverStartPageController : PageControllerBase<EpiserverStartPage>
    {
        public ActionResult Index(EpiserverStartPage currentPage)
        {
            var model = new EpiserverStartPageViewModel(currentPage);

            return View(model);
        }
    }
}