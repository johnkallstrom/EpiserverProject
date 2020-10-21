using EPiServer.Shell;

namespace EpiserverProject.Business.UIDescriptors
{
    [UIDescriptorRegistration]
    public class ContainerIconDescriptor : UIDescriptor<IUseContainerIcon>
    {
        public ContainerIconDescriptor()
        {
            IconClass = EpiserverDefaultIcons.ObjectIcons.Container;
        }
    }
}