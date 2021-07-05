using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class EditImageRequest
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        [Required(ErrorMessage = "Resim boş olamaz.")]
        public string Name { get; set; }
    }
}
