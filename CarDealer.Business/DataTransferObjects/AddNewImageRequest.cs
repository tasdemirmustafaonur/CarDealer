using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class AddNewImageRequest
    {
        public int VehicleId { get; set; }
        [Required(ErrorMessage = "Resim belirtmediniz")]
        public string Name { get; set; }
    }
}
