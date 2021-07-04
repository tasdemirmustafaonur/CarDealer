using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CarDealer.Business.DataTransferObjects;
using CarDealer.Business.Extensions;
using CarDealer.Business.Interfaces;
using CarDealer.DataAccess.Interfaces;
using CarDealer.Models;

namespace CarDealer.Business.Services
{
    public class ModelService : IModelService
    {
        private IModelRepository modelRepository;
        private IMapper mapper;

        public ModelService(IModelRepository modelRepository,IMapper mapper)
        {
            this.modelRepository = modelRepository;
            this.mapper = mapper;
        }
        public IList<ModelListResponse> GetAllModels()
        {
            var dtoList = modelRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }
    }
}
