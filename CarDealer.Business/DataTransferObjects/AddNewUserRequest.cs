using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer.Business.DataTransferObjects
{
    public class AddNewUserRequest
    {
        public int RoleId { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }
        [Required(ErrorMessage = "Adınızı belirtmediniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyadınızı belirtmediniz")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email belirtmediniz")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre belirtmediniz")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Adres belirtmediniz")]
        public string FullAddress { get; set; }
    }
}
