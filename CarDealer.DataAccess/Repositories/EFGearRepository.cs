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
    public class EFGearRepository : IGearRepository
    {
        private VehiclesDbContext db;

        public EFGearRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public Gear Add(Gear entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Gear> GetAll()
        {
            return db.Gears.ToList();
        }

        public Gear GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Gear> GetWithCriteria(Expression<Func<Gear, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Gear Update(Gear entity)
        {
            throw new NotImplementedException();
        }
    }
}
