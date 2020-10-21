using EPiServer.Web.Routing;
using EpiserverProject.Models.Pages;
using EpiserverProject.ViewModels;
using System.Web.Mvc;

namespace EpiserverProject.Business.ActionFilters
{
    public class PageContextActionFilter : IResultFilter
    {
        private readonly PageViewContextFactory _contextFactory;

        public PageContextActionFilter(PageViewContextFactory contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            var viewModel = filterContext.Controller.ViewData.Model;
            var model = viewModel as IPageViewModel<SitePageData>;

            if (model != null)
            {
                var currentContentLink = filterContext.RequestContext.GetContentLink();
                var layoutModel = model.Layout ?? _contextFactory.CreateLayoutModel(currentContentLink, filterContext.RequestContext);
                var layoutController = filterContext.Controller as IModifyLayout;

                if (layoutController != null)
                {
                    layoutController.ModifyLayout(layoutModel);
                }

                model.Layout = layoutModel;
            }
        }

        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
        }
    }
}