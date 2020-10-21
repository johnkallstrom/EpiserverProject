using EPiServer.Data;
using EPiServer.Data.Dynamic;

namespace EpiserverProject.Models
{
    [EPiServerDataStore(AutomaticallyRemapStore = true)]
    public class Rate : IDynamicData
    {
        public Identity Id { get; set; }

        public int Grade { get; set; }
    }
}