using System.ComponentModel.DataAnnotations;

namespace LAMASSUBOOKSTORE.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public Book Book { get; set; }
    }
}
