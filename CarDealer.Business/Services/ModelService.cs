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

        public int AddModel(AddNewModelRequest request)
        {
            var newModel = request.ConvertToModel(mapper);
            modelRepository.Add(newModel);
            return newModel.Id;
        }

        public void DeleteModel(int id)
        {
            modelRepository.Delete(id);
        }

        public IList<ModelListResponse> GetAllModels()
        {
            var dtoList = modelRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public ModelListResponse GetModelById(int id)
        {
            Model model = modelRepository.GetById(id);
            return model.ConvertFromEntity(mapper);
        }

        public int UpdateModel(EditModelRequest request)
        {
            var model = request.ConvertToEntity(mapper);
            int id = modelRepository.Update(model).Id;
            return id;
        }
    }
}
