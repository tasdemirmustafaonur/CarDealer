using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class EditVehicleRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "İlan girmek zorundasınız.")]
        public string Title { get; set; }
        public int Year { get; set; }
        public int KM { get; set; }
        public int Price { get; set; }
        public DateTime AdDate { get; set; }
        public int EnginePower { get; set; }
        public int EngineCapacity { get; set; }
        [Required(ErrorMessage = "Durumu girmek zorundasınız.")]
        public string Condition { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int SeriesId { get; set; }
        public int ModelId { get; set; }
        public int GearId { get; set; }
        public int FuelId { get; set; }
        public int BodyTypeId { get; set; }
        public int WheelDriveId { get; set; }
        public int ColorId { get; set; }
        public int UserId { get; set; }
    }
}
