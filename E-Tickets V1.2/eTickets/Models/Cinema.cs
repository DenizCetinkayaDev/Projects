using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Sinema Logosu")]
        [Required(ErrorMessage = "Sinema logosu gereklidir")]
        public string Logo { get; set; }

        [Display(Name = "Sinema Adı")]
        [Required(ErrorMessage = "Sinema adını giriniz")]
        public string Name { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Lütfen açıklama giriniz")]
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
