using EpiserverProject.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EpiserverProject.Services
{
    public interface IRssFeedService
    {
        IEnumerable<RssFeed> ReadFeed(string url);

        Task<IEnumerable<RssFeed>> ReadFeedAsync(string url);
    }
}
