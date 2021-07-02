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
    public class EFBodyTypeRepository : IBodyTypeRepository
    {
        private VehiclesDbContext db;

        public EFBodyTypeRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public IList<BodyType> GetAll()
        {
            return db.BodyTypes.ToList();
        }

        public BodyType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<BodyType> GetWithCriteria(Expression<Func<BodyType, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public BodyType Add(BodyType entity)
        {
            throw new NotImplementedException();
        }

        public BodyType Update(BodyType entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
