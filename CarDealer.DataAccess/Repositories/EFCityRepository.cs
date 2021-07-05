using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarDealer.DataAccess.Data;
using CarDealer.DataAccess.Interfaces;
using CarDealer.Models;
using Microsoft.EntityFrameworkCore;

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
            db.Cities.Add(entity);
            db.SaveChanges();
            return entity;
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
            return db.Cities.AsNoTracking().Where(x => x.IsDeleted == false).FirstOrDefault(x => x.Id == id);
        }

        public IList<City> GetWithCriteria(Expression<Func<City, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public City Update(City entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return entity;
        }
    }
}
