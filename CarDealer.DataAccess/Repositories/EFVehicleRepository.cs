﻿using System;
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
    public class EFVehicleRepository : IVehicleRepository
    {
        private VehiclesDbContext db;

        public EFVehicleRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public IList<Vehicle> GetAll()
        {
            return db.Vehicles.Where(x => x.IsDeleted==false).ToList();
        }

        public Vehicle GetById(int id)
        {
            return db.Vehicles.AsNoTracking().Where(x => x.IsDeleted == false).FirstOrDefault(x => x.Id == id);
        }

        public IList<Vehicle> GetWithCriteria(Expression<Func<Vehicle, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Vehicle Add(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public Vehicle Update(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
