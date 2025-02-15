using System.ComponentModel.DataAnnotations;

namespace KisanBazaar.Models
{
    public class OrderItem
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
