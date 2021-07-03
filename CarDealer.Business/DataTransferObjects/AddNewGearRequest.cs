using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class AddNewGearRequest
    {
        [Required(ErrorMessage = "Vites adını belirtmediniz")]
        public string Name { get; set; }
    }
}
