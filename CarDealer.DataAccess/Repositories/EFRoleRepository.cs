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
    public class EFRoleRepository : IRoleRepository
    {
        private VehiclesDbContext db;

        public EFRoleRepository(VehiclesDbContext vehiclesDbContext)
        {
            db = vehiclesDbContext;
        }
        public Role Add(Role entity)
        {
            db.Roles.Add(entity);
            db.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Role> GetAll()
        {
            return db.Roles.Where(x => x.IsDeleted == false).ToList();
        }

        public Role GetById(int id)
        {
            return db.Roles.AsNoTracking().Where(x => x.IsDeleted == false).FirstOrDefault(x => x.Id == id);
        }

        public IList<Role> GetWithCriteria(Expression<Func<Role, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Role Update(Role entity)
        {
            db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return entity;
        }
    }
}
