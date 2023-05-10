using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YtBookStore.Models.Domain
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = " عنوان الكتاب  ")]

        public string Title { get; set; }

        [Required]
        [Display(Name = " نوع الكتاب   ")]

        public string Isbn { get; set; }
        [Required]
        [Display(Name = " عدد صفحات الكتاب   ")]

        public int TotalPages { get; set; }

        [Required]
        [Display(Name = "  المؤلف  ")]

        public int AuthorId { get; set; }
        [Required]
        [Display(Name = " الناشر  ")]

        public int PubhlisherId { get; set; }
        [Required]
        [Display(Name = " النوع  ")]

        public int GenreId { get; set; }

        [NotMapped]
        [Display(Name = " اسم المؤلف   ")]

        public string ? AuthorName { get; set; }
        [NotMapped]
        [Display(Name = " اسم الناشر   ")]

        public string ? PublisherName { get; set; }
        [NotMapped]
        public string ? GenreName { get; set; }

        [NotMapped]
        public List<SelectListItem> ? AuthorList { get; set; }
        [NotMapped]
        public List<SelectListItem>? PublisherList { get; set; }
        [NotMapped]
        public List<SelectListItem> ? GenreList { get; set; }

    }
}
