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
    public class VehicleService : IVehicleService
    {
        private IVehicleRepository vehicleRepository;
        private IMapper mapper;

        public VehicleService(IVehicleRepository vehicleRepository, IMapper mapper)
        {
            this.vehicleRepository = vehicleRepository;
            this.mapper = mapper;
        }

        public int AddVehicle(AddNewVehicleRequest request)
        {
            var newVehicle = request.ConvertToVehicle(mapper);
            vehicleRepository.Add(newVehicle);
            return newVehicle.Id;
        }

        public IList<VehicleListResponse> GetAllVehicles()
        {
            var dtoList = vehicleRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public VehicleListResponse GetVehicleById(int id)
        {
            Vehicle vehicle = vehicleRepository.GetById(id);
            return vehicle.ConvertFromEntity(mapper);
        }
    }
}
