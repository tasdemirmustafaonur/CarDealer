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
    public class TownService : ITownService
    {
        private ITownRepository townRepository;
        private IMapper mapper;

        public TownService(ITownRepository townRepository, IMapper mapper)
        {
            this.townRepository = townRepository;
            this.mapper = mapper;
        }
        public IList<TownListResponse> GetAllTowns()
        {
            var dtoList = townRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }
    }
}
