using EPiServer.Shell;
using EpiserverProject.Models.Pages;

namespace EpiserverProject.Business.UIDescriptors
{
    [UIDescriptorRegistration]
    public class ForceAllPropertiesViewUiDescriptor : UIDescriptor<EpiserverStartPage>
    {
        public ForceAllPropertiesViewUiDescriptor()
        {
            DefaultView = CmsViewNames.AllPropertiesView;
        }
    }
}