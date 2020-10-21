using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EpiserverProject.Business.ActionFilters;

namespace EpiserverProject.Business.Initializers
{
    [InitializableModule]
    public class FilterConfig : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            GlobalFilters.Filters.Add(ServiceLocator.Current.GetInstance<PageContextActionFilter>());
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}