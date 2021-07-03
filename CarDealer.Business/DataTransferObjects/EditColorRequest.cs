using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class EditColorRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Renk boş olamaz.")]
        public string Name { get; set; }
    }
}
