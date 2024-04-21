using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profil resmi")]
        [Required(ErrorMessage = "Profil resmi gereklidir")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Ad Soyad giriniz")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "En az 3 en fazla 50 karakter girilebilir")]
        public string FullName { get; set; }

        [Display(Name = "Biyografi")]
        [Required(ErrorMessage = "Biyografi giriniz")]
        public string Bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
