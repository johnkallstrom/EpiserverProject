using EPiServer.ServiceLocation;
using EpiserverProject.Abstractions;
using EpiserverProject.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace EpiserverProject.Controllers
{
    [RoutePrefix("api/rating")]
    public class RatingController : ApiController
    {
        private readonly IRatingService _ratingService = ServiceLocator.Current.GetInstance<IRatingService>();

        [Route("get")]
        [HttpGet]
        public IEnumerable<Rate> GetAll()
        {
            return _ratingService.GetAll();
        }

        [Route("save")]
        [HttpPost]
        public void Save(Rate rate)
        {
            _ratingService.Save(rate);
        }

        [Route("deleteall")]
        [HttpPost]
        public void DeleteAll()
        {
            _ratingService.DeleteAll();
        }

        [Route("delete/{id}")]
        [HttpPost]
        public void Delete(int id)
        {
            _ratingService.Delete(id);
        }
    }
}