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
    public class EFModelRepository : IModelRepository
    {
        private VehiclesDbContext db;
        public EFModelRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public IList<Model> GetAll()
        {
            return db.Models.Where(x => x.IsDeleted == false).ToList();
        }

        public Model GetById(int id)
        {
            return db.Models.AsNoTracking().Where(x => x.IsDeleted == false).FirstOrDefault(x => x.Id == id);
        }

        public IList<Model> GetWithCriteria(Expression<Func<Model, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Model Add(Model entity)
        {
            db.Models.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public Model Update(Model entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            db.Models.Remove(GetById(id));
            db.SaveChanges();
        }
    }
}
