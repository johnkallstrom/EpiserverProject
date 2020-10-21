using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiserverProject.Models.Blocks
{
    [ContentType(
        DisplayName = "Block: RSS", 
        GUID = "8b640dea-20bb-4c56-b516-8d5700aa4d92")]
    public class RssBlock : SiteBlockData
    {
    }
}