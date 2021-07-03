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
    public class ColorService : IColorService
    {
        private IColorRepository colorRepository;
        private IMapper mapper;

        public ColorService(IColorRepository colorRepository,IMapper mapper)
        {
            this.colorRepository = colorRepository;
            this.mapper = mapper;
        }

        public int AddColor(AddNewColorRequest request)
        {
            var newColor = request.ConvertToColor(mapper);
            colorRepository.Add(newColor);
            return newColor.Id;
        }

        public IList<ColorListResponse> GetAllColors()
        {
            var dtoList = colorRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public ColorListResponse GetColorById(int id)
        {
            Color color = colorRepository.GetById(id);
            return color.ConvertFromEntity(mapper);
        }

        public int UpdateColor(EditColorRequest request)
        {
            var color = request.ConvertToEntity(mapper);
            int id = colorRepository.Update(color).Id;
            return id;
        }
    }
}
