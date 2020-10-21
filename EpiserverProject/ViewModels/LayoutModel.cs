using EPiServer.Core;
using System.Collections.Generic;

namespace EpiserverProject.ViewModels
{
    public class LayoutModel
    {
        public IEnumerable<PageData> Menu { get; set; }
    }
}