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
    }
}
