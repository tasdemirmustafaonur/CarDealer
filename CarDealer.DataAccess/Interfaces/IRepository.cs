using CarDealer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.DataAccess.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IEntity, new()
    {
        IList<TEntity> GetAll();
        TEntity GetById(int id);
        IList<TEntity> GetWithCriteria(Expression<Func<TEntity, bool>> criteria);
        TEntity Add(TEntity entity);  //Geriye Eklediği elemanı döndürür. 
        TEntity Update(TEntity entity);
        void Delete(int id);

    }
}
