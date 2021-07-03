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
    public class ColorService : IColorService
    {
        private IColorRepository colorRepository;
        private IMapper mapper;

        public ColorService(IColorRepository colorRepository,IMapper mapper)
        {
            this.colorRepository = colorRepository;
            this.mapper = mapper;
        }
        public IList<ColorListResponse> GetAllColors()
        {
            var dtoList = colorRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }
    }
}
