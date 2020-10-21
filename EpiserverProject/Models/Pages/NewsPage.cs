using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System;
using System.ComponentModel.DataAnnotations;

namespace EpiserverProject.Models.Pages
{
    [ContentType(
        DisplayName = "Page: News", 
        GUID = "8fcd0756-d574-4909-95b7-05cbc59417bc")]
    public class NewsPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [UIHint("Topic")]
        [CultureSpecific]
        [Required]
        public virtual string Topic { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 20)]
        [UIHint(UIHint.Image)]
        [CultureSpecific]
        [Required]
        public virtual ContentReference Image { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 30)]
        [CultureSpecific]
        [Required]
        public virtual DateTime Published { get; set; }

        [Display(
            GroupName = SystemTabNames.Content, 
            Order = 40)]
        [CultureSpecific]
        [Searchable]
        [Required]
        public virtual string Header { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 50)]
        [CultureSpecific]
        [Searchable]
        [Required]
        public virtual string Lead { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 60)]
        [CultureSpecific]
        [Searchable]
        [Required]
        public virtual XhtmlString Text { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 70)]
        [CultureSpecific]
        [Searchable]
        [Required]
        public virtual string Author { get; set; }
    }
}