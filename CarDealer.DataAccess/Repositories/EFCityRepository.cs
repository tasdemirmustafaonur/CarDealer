using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarDealer.DataAccess.Data;
using CarDealer.DataAccess.Interfaces;
using CarDealer.Models;

namespace CarDealer.DataAccess.Repositories
{
    public class EFCityRepository : ICityRepository
    {
        private VehiclesDbContext db;

        public EFCityRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public City Add(City entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<City> GetAll()
        {
            return db.Cities.Where(x => x.IsDeleted == false).ToList();
        }

        public City GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<City> GetWithCriteria(Expression<Func<City, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public City Update(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
