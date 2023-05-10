using System.ComponentModel.DataAnnotations;

namespace YtBookStore.Models.Domain
{
    public class Author
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = " اسم المؤلف  ")]

        public string AuthorName { get; set; }
    }
}
