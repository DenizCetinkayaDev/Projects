using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profil Fotoğrafı")]
        [Required(ErrorMessage = "Profil fotoğrafı gereklidir")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Tam Ad")]
        [Required(ErrorMessage = "Tam ad gereklidir")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "En az 3 en fazla 50 karakter girilebilir")]
        public string FullName { get; set; }

        [Display(Name = "Biyografi")]
        [Required(ErrorMessage = "Biyografi girilmesi gereklidir")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
