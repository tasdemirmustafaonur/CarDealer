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
    public class EFFuelRepository : IFuelRepository
    {
        private VehiclesDbContext db;

        public EFFuelRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public Fuel Add(Fuel entity)
        {
            db.Fuels.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            db.Fuels.Remove(GetById(id));
            db.SaveChanges();
        }

        public IList<Fuel> GetAll()
        {
            return db.Fuels.Where(x => x.IsDeleted == false).ToList();
        }

        public Fuel GetById(int id)
        {
            return db.Fuels.AsNoTracking().Where(x => x.IsDeleted == false).FirstOrDefault(x => x.Id == id);
        }

        public IList<Fuel> GetWithCriteria(Expression<Func<Fuel, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Fuel Update(Fuel entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return entity;
        }
    }
}
