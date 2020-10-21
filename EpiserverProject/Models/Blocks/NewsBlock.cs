using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiserverProject.Models.Blocks
{
    [ContentType(
        DisplayName = "Block: News Container", 
        GUID = "49798e26-2de5-4aa9-b9cf-d3c4c984462e")]
    public class NewsBlock : SiteBlockData
    {
        [Display(
            GroupName = SystemTabNames.Content, 
            Order = 10)]
        [Required]
        public virtual PageReference NewsContainer { get; set; }
    }
}