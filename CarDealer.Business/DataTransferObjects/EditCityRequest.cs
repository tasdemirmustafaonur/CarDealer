using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class EditCityRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Şehir boş olamaz.")]
        public string Name { get; set; }
    }
}
