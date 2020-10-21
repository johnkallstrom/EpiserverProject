using EPiServer.Data.Dynamic;
using EpiserverProject.Abstractions;
using EpiserverProject.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EpiserverProject.Services
{
    public class RatingService : IRatingService
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private readonly DynamicDataStore _store = DynamicDataStoreFactory.Instance.CreateStore(typeof(Rate));

        public void Save(Rate rate)
        {
            _store.Save(rate);
        }

        public IEnumerable<Rate> GetAll()
        {
            return _store.Items<Rate>();
        }

        public void DeleteAll()
        {
            _store.DeleteAll();
        }

        public void Delete(int id)
        {
            var item = _store.Items<Rate>().FirstOrDefault(x => x.Id.StoreId == id);

            if (item != null)
            {
                try
                {
                    _store.Delete(item.Id);
                }
                catch (Exception e)
                {
                    Log.Error(e.Message);
                }
            }
        }
    }
}