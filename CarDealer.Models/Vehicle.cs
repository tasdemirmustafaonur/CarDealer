using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public class Vehicle : IEntity
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "İlan Başlığı girmek zorundasınız.")]
        [MaxLength(200,ErrorMessage = "İlan başlığı en fazla 200 karakter olmalı.")]
        [MinLength(5,ErrorMessage = "İlan başlığı en az 10 karakter olmalı.")]
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
        public virtual Category Category {get; set;}
        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public int SeriesId { get; set; }
        public virtual Series Series { get; set; }
        public int ModelId { get; set; }
        public virtual Model Model { get; set; }
        public int GearId { get; set; }
        public virtual Gear Gear { get; set; }
        public int FuelId { get; set; }
        public virtual Fuel Fuel { get; set; }
        public int BodyTypeId { get; set; }
        public virtual BodyType BodyType { get; set; }
        public int WheelDriveId { get; set; }
        public virtual WheelDrive WheelDrive { get; set; }
        public int ColorId { get; set; }
        public virtual Color Color { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual IList<Image> Images { get; set; }
        



    }
}
