using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class EditBrandRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Marka boş olamaz.")]
        public string Name { get; set; }
    }
}
