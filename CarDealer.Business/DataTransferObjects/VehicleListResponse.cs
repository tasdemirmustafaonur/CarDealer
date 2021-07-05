using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class VehicleListResponse
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İlan Başlığı girmek zorundasınız.")]
        [MaxLength(200, ErrorMessage = "İlan başlığı en fazla 200 karakter olmalı.")]
        [MinLength(5, ErrorMessage = "İlan başlığı en az 10 karakter olmalı.")]
        public string Title { get; set; }
        public int Year { get; set; }
        public int KM { get; set; }
        public int Price { get; set; }
        public DateTime AdDate { get; set; }
        public int SeriesId { get; set; }
        public int ModelId { get; set; }
        public int ColorId { get; set; }
        public int ImageId { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }
        
    }
}
