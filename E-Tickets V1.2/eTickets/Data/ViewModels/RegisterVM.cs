using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Kullanıcı adı")]
        [Required(ErrorMessage = "Kullanıcı Adı Gereklidir")]
        public string FullName { get; set; }

        [Display(Name = "Email adresi")]
        [Required(ErrorMessage = "Email adresi zorunludur")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Şifre Doğrulama")]
        [Required(ErrorMessage = "Şifrenizi Doğrulayın")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Şifreler uyumsuz")]
        public string ConfirmPassword { get; set; }
    }
}
