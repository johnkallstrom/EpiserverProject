using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EpiserverProject.Models.Pages;
using EpiserverProject.ViewModels;
using System.Linq;
using System.Web.Routing;

namespace EpiserverProject.Business
{
    public class PageViewContextFactory
    {
        private readonly IContentLoader _contentLoader;

        public PageViewContextFactory(IContentLoader contentLoader)
        {
            _contentLoader = contentLoader;
        }

        public virtual LayoutModel CreateLayoutModel(ContentReference currentContentLink, RequestContext requestContext)
        {
            var startPageContentLink = SiteDefinition.Current.StartPage;

            if (currentContentLink.CompareToIgnoreWorkID(startPageContentLink))
            {
                startPageContentLink = currentContentLink;
            }

            var startPage = _contentLoader.Get<EpiserverStartPage>(startPageContentLink);

            return new LayoutModel
            {
                Menu = _contentLoader.GetChildren<PageData>(startPage.ContentLink).Where(x => x.VisibleInMenu)
            };
        }
    }
}