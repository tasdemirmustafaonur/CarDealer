using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class AddNewModelRequest
    {
        public int SeriesId { get; set; }
        [Required(ErrorMessage = "Kasa tipi adını belirtmediniz")]
        public string Name { get; set; }
    }
}
