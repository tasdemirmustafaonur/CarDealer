using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class AddNewRoleRequest
    {
        [Required(ErrorMessage = "Rol belirtmediniz")]
        public string Name { get; set; }
    }
}
