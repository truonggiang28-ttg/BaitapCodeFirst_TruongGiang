using System.ComponentModel.DataAnnotations;

namespace LibraryMVC.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        public string? Author { get; set; }

        public decimal Price { get; set; }
    }
}