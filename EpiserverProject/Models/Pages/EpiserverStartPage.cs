using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EpiserverProject.Models.Containers;
using System.ComponentModel.DataAnnotations;

namespace EpiserverProject.Models.Pages
{
    [ContentType(
        DisplayName = "Page: Start Page", 
        GUID = "03ed2667-bb59-4b3d-aef5-9ed2acc21599")]
    [AvailableContentTypes(
        Availability.Specific, 
        Include = new[] { typeof(NewsContainer), typeof(AboutPage), typeof(CulturePage) })]
    public class EpiserverStartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString Body { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30
        )]
        public virtual ContentArea ContentArea { get; set; }
    }
}