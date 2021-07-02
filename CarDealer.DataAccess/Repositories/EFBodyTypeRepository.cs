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
            return db.BodyTypes.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IList<BodyType> GetWithCriteria(Expression<Func<BodyType, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public BodyType Add(BodyType entity)
        {
            db.BodyTypes.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public BodyType Update(BodyType entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            db.BodyTypes.Remove(GetById(id));
            db.SaveChanges();
        }
    }
}
