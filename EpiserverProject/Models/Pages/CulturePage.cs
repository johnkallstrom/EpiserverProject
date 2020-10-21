using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiserverProject.Models.Pages
{
    [ContentType(
        DisplayName = "Page: Culture", 
        GUID = "95e234de-4181-4b00-8a52-f582ced8d420")]
    public class CulturePage : SitePageData
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
    }
}