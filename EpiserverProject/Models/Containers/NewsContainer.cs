using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EpiserverProject.Business.UIDescriptors;
using EpiserverProject.Models.Pages;

namespace EpiserverProject.Models.Containers
{
    [ContentType(
        GUID = "8815A90D-17E4-4175-B077-108747821069",
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "Container: News"
    )]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(NewsPage) }
    )]
    public class NewsContainer : SitePageData, IUseContainerIcon
    {
    }
}