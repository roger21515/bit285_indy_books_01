using System;
using System.ComponentModel.DataAnnotations;

namespace IndyBooks.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Author Name")]
        public string Author { get; set; }

        [Display(Name = "Edition")]
        public string Edition { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Publication Year")]
        public string Year { get; set; }
    }
}
