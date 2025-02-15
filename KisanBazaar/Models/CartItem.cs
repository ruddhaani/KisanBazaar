using System.ComponentModel.DataAnnotations;

namespace KisanBazaar.Models
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }

        public int CartId { get; set; }

        public int ProductId { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
