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
    public class GearService : IGearService
    {
        private IGearRepository gearRepository;
        private IMapper mapper;

        public GearService(IGearRepository gearRepository, IMapper mapper)
        {
            this.gearRepository = gearRepository;
            this.mapper = mapper;
        }

        public int AddGear(AddNewGearRequest request)
        {
            var newGear = request.ConvertToGear(mapper);
            gearRepository.Add(newGear);
            return newGear.Id;
        }

        public IList<GearListResponse> GetAllGears()
        {
            var dtoList = gearRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public GearListResponse GetGearById(int id)
        {
            Gear gear = gearRepository.GetById(id);
            return gear.ConvertFromEntity(mapper);
        }

        public int UpdateGear(EditGearRequest request)
        {
            var gear = request.ConvertToEntity(mapper);
            int id = gearRepository.Update(gear).Id;
            return id;
        }
    }
}
