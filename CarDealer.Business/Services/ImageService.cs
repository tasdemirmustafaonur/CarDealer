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

        public int AddImage(AddNewImageRequest request)
        {
            var newImage = request.ConvertToImage(mapper);
            imageRepository.Add(newImage);
            return newImage.Id;
        }

        public int UpdateImage(EditImageRequest request)
        {
            var image = request.ConvertToEntity(mapper);
            int id = imageRepository.Update(image).Id;
            return id;
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

        public void DeleteImage(int id)
        {
            Image image = imageRepository.GetById(id);
            image.IsDeleted = true;
            imageRepository.Update(image);
        }
    }
}
