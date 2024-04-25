using System.ComponentModel.DataAnnotations;

namespace LAMASSUBOOKSTORE.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        public string Bio { get; set; }
        // required to be a positive number
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
