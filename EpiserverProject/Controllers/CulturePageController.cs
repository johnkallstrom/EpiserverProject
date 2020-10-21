using System.Web.Mvc;
using EpiserverProject.Models.Pages;
using EpiserverProject.ViewModels;

namespace EpiserverProject.Controllers
{
    public class CulturePageController : PageControllerBase<CulturePage>
    {
        public ActionResult Index(CulturePage currentPage)
        {
            var model = new CulturePageViewModel(currentPage);

            return View(model);
        }
    }
}