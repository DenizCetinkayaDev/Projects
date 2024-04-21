using eTickets.Data;
using eTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Film Adı")]
        [Required(ErrorMessage = "Film Adı gereklidir")]
        public string Name { get; set; }

        [Display(Name = "Film Özeti")]
        [Required(ErrorMessage = "Film özeti")]
        public string Description { get; set; }

        [Display(Name = "Fiyat TL")]
        [Required(ErrorMessage = "Fiyat giriniz")]
        public double Price { get; set; }

        [Display(Name = "Film Poster URL'si")]
        [Required(ErrorMessage = "Film Posteri")]
        public string ImageURL { get; set; }

        [Display(Name = "Vizyona Giriş")]
        [Required(ErrorMessage = "Film Adı gereklidir")]
        public DateTime StartDate { get; set; }

        [Display(Name = "Vizyondan Çıkış")]
        [Required(ErrorMessage = "Tarih gereklidir")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Bir kategori seçiniz")]
        [Required(ErrorMessage = "Film kategorisi gereklidir")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        [Display(Name = "Bir veya birden fazla oyuncu seçiniz")]
        [Required(ErrorMessage = "Oyuncular gereklidir")]
        public List<int> ActorIds { get; set; }

        [Display(Name = "Sinema Adı")]
        [Required(ErrorMessage = "Sinema gereklidir")]
        public int CinemaId { get; set; }

        [Display(Name = "Yapımcı seçiniz")]
        [Required(ErrorMessage = "Film yapımcısı gereklidir")]
        public int ProducerId { get; set; }
    }
}
