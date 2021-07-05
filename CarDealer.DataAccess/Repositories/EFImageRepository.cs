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
    public class EFImageRepository : IImageRepository
    {
        private VehiclesDbContext db;

        public EFImageRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public Image Add(Image entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Image> GetAll()
        {
            throw new NotImplementedException();
        }

        public Image GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Image> GetWithCriteria(Expression<Func<Image, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Image Update(Image entity)
        {
            throw new NotImplementedException();
        }
    }
}
