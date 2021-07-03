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
    public class EFColorRepository : IColorRepository
    {
        private VehiclesDbContext db;

        public EFColorRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public Color Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Color> GetAll()
        {
            return db.Colors.ToList();
        }

        public Color GetById(int id)
        {
            return db.Colors.AsNoTracking().FirstOrDefault(x => x.Id == id);
        }

        public IList<Color> GetWithCriteria(Expression<Func<Color, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Color Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
