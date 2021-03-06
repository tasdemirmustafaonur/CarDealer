using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Models
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public int TownId { get; set; }
        public virtual Town Town { get; set; }
        public string FullAddress { get; set; }
        public bool IsDeleted { get; set; }

    }
}
