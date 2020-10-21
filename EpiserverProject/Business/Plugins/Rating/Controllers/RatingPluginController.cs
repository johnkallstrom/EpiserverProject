using EPiServer.PlugIn;
using EPiServer.ServiceLocation;
using EpiserverProject.Abstractions;
using EpiserverProject.Business.Plugins.Rating.ViewModels;
using System.Web.Mvc;

namespace EpiserverProject.Business.Plugins.Rating.Controllers
{
    [GuiPlugIn(Area = PlugInArea.AdminMenu, Url = "/RatingPlugin", DisplayName = "Rating Plugin")]
    [Authorize(Roles = "Administrators, WebAdmins, CmsAdmins")]
    public class RatingPluginController : Controller
    {
        private readonly IRatingService _ratingService = ServiceLocator.Current.GetInstance<IRatingService>();

        public ActionResult Index()
        {
            var model = new RatingViewModel();

            return View("~/Business/Plugins/Rating/Views/Index.cshtml", model);
        }
    }
}