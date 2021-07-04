using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public class Series : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Seri girmek zorundasınız.")]
        public string Name { get; set; }

        public int BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        public bool IsDeleted { get; set; }


    }
}
