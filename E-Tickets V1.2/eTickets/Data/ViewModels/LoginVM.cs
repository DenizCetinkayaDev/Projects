using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email adresi gereklidir")]
        public string EmailAddress { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage ="Şifrenizi giriniz")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
