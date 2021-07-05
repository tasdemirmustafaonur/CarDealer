using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class AddNewTownRequest
    {
        public int CityId { get; set; }
        [Required(ErrorMessage = "İlçe adını belirtmediniz")]
        public string Name { get; set; }
    }
}
