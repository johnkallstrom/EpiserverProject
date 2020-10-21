using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using EpiserverProject.Abstractions;
using EpiserverProject.Business.Modules;
using EpiserverProject.Services;
using System.Web.Mvc;

namespace EpiserverProject.Business.Initializers
{
    [InitializableModule]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.ConfigurationComplete += (o, e) =>
            {
                context.Services.AddTransient<IRatingService, RatingService>();
                context.Services.AddTransient<IRssFeedService, RssFeedService>();
            };
        }

        public void Initialize(InitializationEngine context)
        {
            DependencyResolver.SetResolver(new ServiceLocatorDependencyResolver(context.Locate.Advanced));
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}