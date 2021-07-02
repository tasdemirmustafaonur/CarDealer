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
    public class BodyTypeService : IBodyTypeService
    {
        private IBodyTypeRepository bodyTypeRepository;
        private IMapper mapper;

        public BodyTypeService(IBodyTypeRepository bodyTypeRepository,IMapper mapper)
        {
            this.bodyTypeRepository = bodyTypeRepository;
            this.mapper = mapper;
        }
        public IList<BodyTypeListResponse> GetAllBodyTypes()
        {
            var dtoList = bodyTypeRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public BodyTypeListResponse GetBodyTypeById(int id)
        {
            BodyType bodyType = bodyTypeRepository.GetById(id);
            return bodyType.ConvertFromEntity(mapper);
        }

        public int AddBodyType(AddNewBodyTypeRequest request)
        {
            var newBodyType = request.ConvertToBodyType(mapper);
            bodyTypeRepository.Add(newBodyType);
            return newBodyType.Id;
        }

        public int UpdateBodyType(EditBodyTypeRequest request)
        {
            var bodyType = request.ConvertToEntity(mapper);
            int id = bodyTypeRepository.Update(bodyType).Id;
            return id;
        }

        public void DeleteBodyType(int id)
        {
            bodyTypeRepository.Delete(id);
        }
    }
}
