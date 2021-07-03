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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Series> GetAll()
        {
            return db.Series.ToList();
        }

        public Series GetById(int id)
        {
            return db.Series.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IList<Series> GetWithCriteria(Expression<Func<Series, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Series Update(Series entity)
        {
            throw new NotImplementedException();
        }
        
    }
}
