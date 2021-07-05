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
    public class CityService : ICityService
    {
        private ICityRepository cityRepository;
        private IMapper mapper;

        public CityService(ICityRepository cityRepository, IMapper mapper)
        {
            this.cityRepository = cityRepository;
            this.mapper = mapper;
        }

        public int AddCity(AddNewCityRequest request)
        {
            var newCity = request.ConvertToCity(mapper);
            cityRepository.Add(newCity);
            return newCity.Id;
        }

        public IList<CityListResponse> GetAllCities()
        {
            var dtoList = cityRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public CityListResponse GetCityById(int id)
        {
            City city = cityRepository.GetById(id);
            return city.ConvertFromEntity(mapper);
        }

        public int UpdateCity(EditCityRequest request)
        {
            var city = request.ConvertToEntity(mapper);
            int id = cityRepository.Update(city).Id;
            return id;
        }
    }
}
