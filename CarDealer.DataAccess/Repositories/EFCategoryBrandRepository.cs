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
    public class EFCategoryBrandRepository : ICategoryBrandRepository
    {
        private VehiclesDbContext db;

        public EFCategoryBrandRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public CategoryBrand Add(CategoryBrand entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<CategoryBrand> getCategoryBrandsByCategoryId(int categoryId)
        {
            return db.CategoryBrands.Where(x => x.CategoryId == categoryId).ToList();
        }

        public IList<CategoryBrand> GetAll()
        {
            return db.CategoryBrands.ToList();
        }

        public CategoryBrand GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<CategoryBrand> GetWithCriteria(Expression<Func<CategoryBrand, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public CategoryBrand Update(CategoryBrand entity)
        {
            throw new NotImplementedException();
        }
    }
}
