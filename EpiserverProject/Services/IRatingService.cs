using EpiserverProject.Models;
using System.Collections.Generic;

namespace EpiserverProject.Abstractions
{
    public interface IRatingService
    {
        void Save(Rate rate);

        IEnumerable<Rate> GetAll();

        void DeleteAll();

        void Delete(int id);
    }
}
