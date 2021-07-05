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
    public class EFTownRepository : ITownRepository
    {
        private VehiclesDbContext db;

        public EFTownRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public Town Add(Town entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public IList<Town> GetWithCriteria(Expression<Func<Town, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Town Update(Town entity)
        {
            throw new NotImplementedException();
        }
    }
}
