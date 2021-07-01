using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Business.Interfaces;
using CarDealer.DataAccess.Interfaces;
using CarDealer.Models;

namespace CarDealer.Business.Services
{
    public class ModelService : IModelService
    {
        private IModelRepository modelRepository;
        public ModelService(IModelRepository modelRepository)
        {
            this.modelRepository = modelRepository;
        }
        public IList<Model> GetAllModels()
        {
            var result = modelRepository.GetAll().ToList();
            //List<CategoryResponseList> result = new List<CategoryResponseList>();
            //dtoList.ForEach(g => result.Add(new CategoryResponseList
            //{
            //    Id = g.Id,
            //    Name = g.Name
            //}));
            return result;
        }
    }
}
