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
    public class EFWheelDriveRepository : IWheelDriveRepository
    {
        private VehiclesDbContext db;

        public EFWheelDriveRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public WheelDrive Add(WheelDrive entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<WheelDrive> GetAll()
        {
            return db.WheelDrives.ToList();
        }

        public WheelDrive GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<WheelDrive> GetWithCriteria(Expression<Func<WheelDrive, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public WheelDrive Update(WheelDrive entity)
        {
            throw new NotImplementedException();
        }
    }
}
