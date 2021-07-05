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
    public class ImageService : IImageService
    {
        private IImageRepository imageRepository;
        private IMapper mapper;

        public ImageService(IImageRepository imageRepository, IMapper mapper)
        {
            this.imageRepository = imageRepository;
            this.mapper = mapper;
        }
        public IList<ImageListResponse> GetAllImages()
        {
            var dtoList = imageRepository.GetAll().ToList();
            var result = dtoList.ConvertToListResponse(mapper);
            return result;
        }

        public ImageListResponse GetImageById(int id)
        {
            Image image = imageRepository.GetById(id);
            return image.ConvertFromEntity(mapper);
        }
    }
}
