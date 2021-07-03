using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class EditWheelDriveRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Çekiş tipi boş olamaz.")]
        public string Name { get; set; }
    }
}
