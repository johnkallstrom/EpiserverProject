using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace EpiserverProject.Models.Pages
{
    [ContentType(
        DisplayName = "Page: About", 
        GUID = "45ea4cc2-e9ad-4a88-9be8-935aa1a20eba")]
    public class AboutPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [Required]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [Required]
        public virtual string SubHeader { get; set; }

        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [Required]
        public virtual XhtmlString Body { get; set; }

        [CultureSpecific]
        [Display(
        GroupName = SystemTabNames.Content,
        Order = 40)]
        [UIHint(UIHint.Image)]
        [Required]
        public virtual ContentReference Image { get; set; }
    }
}