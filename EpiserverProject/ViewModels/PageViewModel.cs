using EPiServer.Core;

namespace EpiserverProject.ViewModels
{
    public class PageViewModel<T> : IPageViewModel<T> where T : PageData
    {
        public T CurrentPage { get; private set; }

        public LayoutModel Layout { get; set; }

        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }
    }
}