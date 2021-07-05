using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarDealer.Models;

namespace CarDealer.Business.DataTransferObjects
{
    public class VehicleListResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int KM { get; set; }
        public int Price { get; set; }
        public DateTime AdDate { get; set; }
        public int SeriesId { get; set; }
        public int ModelId { get; set; }
        public int ColorId { get; set; }
        public IList<ImageListResponse> Images { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }
        
    }
}
