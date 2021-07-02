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
    public class GearService : IGearService
    {
        private IGearRepository gearRepository;
        private IMapper mapper;

        public GearService(IGearRepository gearRepository, IMapper mapper)
        {
            this.gearRepository = gearRepository;
            this.mapper = mapper;
        }
        public IList<GearListResponse> GetAllGears()
        {
            var dtoList = gearRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }
    }
}
