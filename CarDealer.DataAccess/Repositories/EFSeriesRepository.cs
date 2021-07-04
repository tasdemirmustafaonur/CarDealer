using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    public class EFSeriesRepository : ISeriesRepository
    {
        private VehiclesDbContext db;

        public EFSeriesRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public Series Add(Series entity)
        {
            db.Series.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            db.Series.Remove(GetById(id));
            db.SaveChanges();
        }

        public IList<Series> GetAll()
        {
            return db.Series.Where(x => x.IsDeleted == false).ToList();
        }

        public Series GetById(int id)
        {
            return db.Series.AsNoTracking().Where(x => x.IsDeleted == false).FirstOrDefault(x => x.Id == id);
        }

        public IList<Series> GetWithCriteria(Expression<Func<Series, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Series Update(Series entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return entity;
        }
        
    }
}
