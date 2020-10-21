using EPiServer.Core;

namespace EpiserverProject.ViewModels
{
    public interface IPageViewModel<out T> where T : PageData
    {
        T CurrentPage { get; }

        LayoutModel Layout { get; set; }
    }
}
