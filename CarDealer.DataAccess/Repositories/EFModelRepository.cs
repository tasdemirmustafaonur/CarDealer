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
    public class EFModelRepository : IModelRepository
    {
        private VehiclesDbContext db;
        public EFModelRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public IList<Model> GetAll()
        {
            return db.Models.ToList();
        }

        public Model GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Model> GetWithCriteria(Expression<Func<Model, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Model Add(Model entity)
        {
            throw new NotImplementedException();
        }

        public Model Update(Model entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
