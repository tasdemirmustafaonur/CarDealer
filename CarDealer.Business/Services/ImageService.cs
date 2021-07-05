using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CarDealer.Business.DataTransferObjects;
using CarDealer.Business.Interfaces;
using CarDealer.DataAccess.Interfaces;

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
            throw new NotImplementedException();
        }
    }
}
