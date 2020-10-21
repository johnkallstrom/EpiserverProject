using EPiServer.Shell.Security;
using EPiServer.Web.Mvc;
using EpiserverProject.Business;
using EpiserverProject.Models.Pages;
using EpiserverProject.ViewModels;
using System.Web.Mvc;

namespace EpiserverProject.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T>, IModifyLayout where T : SitePageData
    {
        protected EPiServer.ServiceLocation.Injected<UISignInManager> UISignInManager;

        public ActionResult Logout()
        {
            UISignInManager.Service.SignOut();

            return RedirectToAction("Index");
        }

        public virtual void ModifyLayout(LayoutModel layoutModel)
        {
            var page = PageContext.Page as SitePageData;
        }
    }
}