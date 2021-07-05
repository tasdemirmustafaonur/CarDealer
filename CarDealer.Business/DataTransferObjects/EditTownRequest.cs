using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class EditTownRequest
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        [Required(ErrorMessage = "İlçe boş olamaz.")]
        public string Name { get; set; }
    }
}
