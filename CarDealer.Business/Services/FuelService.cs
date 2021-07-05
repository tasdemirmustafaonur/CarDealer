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
    public class FuelService : IFuelService
    {
        private IFuelRepository fuelRepository;
        private IMapper mapper;

        public FuelService(IFuelRepository fuelRepository, IMapper mapper)
        {
            this.fuelRepository = fuelRepository;
            this.mapper = mapper;
        }
        public IList<FuelListResponse> GetAllFuels()
        {
            var dtoList = fuelRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper); 
            return result;
        }

        public FuelListResponse GetFuelById(int id)
        {
            Fuel fuel = fuelRepository.GetById(id);
            return fuel.ConvertFromEntity(mapper);
        }

        public int AddFuel(AddNewFuelRequest request)
        {
            var newFuel = request.ConvertToFuel(mapper);
            fuelRepository.Add(newFuel);
            return newFuel.Id;
        }

        public int UpdateFuel(EditFuelRequest request)
        {
            var fuel = request.ConvertToEntity(mapper);
            int id = fuelRepository.Update(fuel).Id;
            return id;
        }

        public void DeleteFuel(int id)
        {
            Fuel fuel = fuelRepository.GetById(id);
            fuel.IsDeleted = true;
            fuelRepository.Update(fuel);
        }
    }
}
