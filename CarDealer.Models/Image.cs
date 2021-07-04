using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public class Image : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Resim girmek zorundasınız.")]
        public string ImageUrl { get; set; }

        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public bool IsDeleted { get; set; }

    }
}
