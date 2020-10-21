using EPiServer.Shell;

namespace EpiserverProject.Business.UIDescriptors
{
    [UIDescriptorRegistration]
    public class CategoryIconDescriptor : UIDescriptor<IUseCategoryIcon>
    {
        public CategoryIconDescriptor()
        {
            IconClass = EpiserverDefaultIcons.ActionIcons.Category;
        }
    }
}