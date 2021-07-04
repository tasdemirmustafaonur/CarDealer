using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class AddNewSeriesRequest
    {
        public int BrandId { get; set; }
        [Required(ErrorMessage = "Seri tipi adını belirtmediniz")]
        public string Name { get; set; }
    }
}
