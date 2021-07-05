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
    public class EFTownRepository : ITownRepository
    {
        private VehiclesDbContext db;

        public EFTownRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public Town Add(Town entity)
        {
            db.Towns.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Town> GetAll()
        {
            return db.Towns.Where(x => x.IsDeleted == false).ToList();
        }

        public Town GetById(int id)
        {
            return db.Towns.AsNoTracking().Where(x => x.IsDeleted == false).FirstOrDefault(x => x.Id == id);
        }

        public IList<Town> GetWithCriteria(Expression<Func<Town, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Town Update(Town entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return entity;
        }
    }
}
