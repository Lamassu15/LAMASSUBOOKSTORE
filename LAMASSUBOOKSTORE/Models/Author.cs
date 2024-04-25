using System.ComponentModel.DataAnnotations;

namespace LAMASSUBOOKSTORE.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
