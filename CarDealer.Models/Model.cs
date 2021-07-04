using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public class Model : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Model girmek zorundasınız.")]
        public string Name { get; set; }
        public int SeriesId { get; set; }
        public virtual Series Series { get; set; }
        public bool IsDeleted { get; set; }
    }
}
