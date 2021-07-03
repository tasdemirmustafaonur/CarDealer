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
    public class EFGearRepository : IGearRepository
    {
        private VehiclesDbContext db;

        public EFGearRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public Gear Add(Gear entity)
        {
            db.Gears.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            db.Gears.Remove(GetById(id));
            db.SaveChanges();
        }

        public IList<Gear> GetAll()
        {
            return db.Gears.ToList();
        }

        public Gear GetById(int id)
        {
            return db.Gears.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IList<Gear> GetWithCriteria(Expression<Func<Gear, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Gear Update(Gear entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return entity;
        }
    }
}
