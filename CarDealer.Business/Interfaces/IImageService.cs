using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Business.DataTransferObjects;

namespace CarDealer.Business.Interfaces
{
    public interface IImageService
    {
        IList<ImageListResponse> GetAllImages();
        ImageListResponse GetImageById(int id);
    }
}
