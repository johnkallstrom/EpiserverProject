using EpiserverProject.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EpiserverProject.Services
{
    public class RssFeedService : IRssFeedService
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public IEnumerable<RssFeed> ReadFeed(string url)
        {
            IEnumerable<RssFeed> rssFeedData = Enumerable.Empty<RssFeed>();

            try
            {
                using (WebClient client = new WebClient())
                {
                    string rssData = client.DownloadString(url);

                    XDocument xml = XDocument.Parse(rssData);

                    rssFeedData = xml.Descendants("item").Select(x => new RssFeed
                    {
                        Title = (string)x.Element("title"),
                        Link = (string)x.Element("link"),
                        Description = (string)x.Element("description"),
                        PubDate = (string)x.Element("pubDate")
                    });
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            return rssFeedData.Take(10);
        }

        public async Task<IEnumerable<RssFeed>> ReadFeedAsync(string url)
        {
            IEnumerable<RssFeed> rssFeedData = Enumerable.Empty<RssFeed>();

            try
            {
                using (WebClient client = new WebClient())
                {
                    string rssData = await client.DownloadStringTaskAsync(url);

                    XDocument xml = XDocument.Parse(rssData);

                    rssFeedData = xml.Descendants("item").Select(x => new RssFeed
                    {
                        Title = (string)x.Element("title"),
                        Link = (string)x.Element("link"),
                        Description = (string)x.Element("description"),
                        PubDate = (string)x.Element("pubDate")
                    });
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            return rssFeedData.Take(10);
        }
    }
}