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
    public class EFBrandRepository : IBrandRepository
    {
        private VehiclesDbContext db;

        public EFBrandRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public Brand Add(Brand entity)
        {
            db.Brands.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            db.Brands.Remove(GetById(id));
            db.SaveChanges();
        }

        public IList<Brand> GetBrandsWithList(List<int> BrandIdList)
        {
            return db.Brands.Where(x => BrandIdList.Contains(x.Id)).ToList();
        }

        public IList<Brand> GetAll()
        {
            return db.Brands.Where(x => x.IsDeleted == false).ToList();
        }

        public Brand GetById(int id)
        {
            return db.Brands.AsNoTracking().Where(x => x.IsDeleted == false).FirstOrDefault(x=>x.Id==id);
        }

        public IList<Brand> GetWithCriteria(Expression<Func<Brand, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Brand Update(Brand entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return entity;
        }
    }
}
