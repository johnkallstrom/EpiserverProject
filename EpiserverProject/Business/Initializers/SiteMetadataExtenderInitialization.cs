using EPiServer.Cms.Shell;
using EPiServer.Core;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Shell.ObjectEditing;
using EpiserverProject.Business.MetadataExtenders;

namespace EpiserverProject.Business.Initializers
{
    [InitializableModule]
    [ModuleDependency(typeof(InitializableModule))]
    public class SiteMetadataExtenderInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if (context.HostType == HostType.WebApplication)
            {
                var registry = context.Locate.Advanced.GetInstance<MetadataHandlerRegistry>();
                registry.RegisterMetadataHandler(typeof(ContentData), new SiteMetadataExtender());
            }
        }

        public void Preload(string[] parameters) { }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}