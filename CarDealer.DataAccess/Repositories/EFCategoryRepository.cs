using CarDealer.DataAccess.Interfaces;
using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarDealer.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace CarDealer.DataAccess.Repositories
{
    public class EFCategoryRepository : ICategoryRepository
    {
        private VehiclesDbContext db;

        public EFCategoryRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public Category Add(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            db.Categories.Remove(GetById(id));
            db.SaveChanges();
        }

        public IList<Category> GetAll()
        {
            return db.Categories.Where(x => x.IsDeleted == false).ToList();
        }

        public Category GetById(int id)
        {
            return db.Categories.AsNoTracking().Where(x => x.IsDeleted == false).FirstOrDefault(x=>x.Id == id);
        }

        public IList<Category> GetWithCriteria(Expression<Func<Category, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Category Update(Category entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return entity;
        }
    }
}
