using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public class WheelDrive : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Çekiş tipi girmek zorundasınız.")]
        public string Name { get; set; }
    }
}
