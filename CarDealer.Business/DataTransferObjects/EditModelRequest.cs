using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class EditModelRequest
    {
        public int Id { get; set; }
        public int SeriesId { get; set; }
        [Required(ErrorMessage = "Seri boş olamaz.")]
        public string Name { get; set; }
    }
}
