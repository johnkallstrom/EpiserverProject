using EpiserverProject.Models.Pages;

namespace EpiserverProject.ViewModels
{
    public class NewsPageViewModel : PageViewModel<NewsPage>
    {
        public NewsPageViewModel(NewsPage currentPage) : base(currentPage)
        {
        }
    }
}