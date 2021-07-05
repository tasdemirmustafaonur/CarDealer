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
    public class EFImageRepository : IImageRepository
    {
        private VehiclesDbContext db;

        public EFImageRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public Image Add(Image entity)
        {
            db.Images.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Image> GetAll()
        {
            return db.Images.Where(x => x.IsDeleted == false).ToList();
        }

        public Image GetById(int id)
        {
            return db.Images.AsNoTracking().Where(x => x.IsDeleted == false).FirstOrDefault(x => x.Id == id);
        }

        public IList<Image> GetWithCriteria(Expression<Func<Image, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Image Update(Image entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return entity;
        }
    }
}
