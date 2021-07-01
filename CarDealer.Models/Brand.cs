using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public class Brand : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Marka girmek zorundasınız.")]
        public string Name { get; set; }
        public virtual IList<CategoryBrand> Categories { get; set; }


    }
}
