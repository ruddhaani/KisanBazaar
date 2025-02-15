namespace KisanBazaar.Models
{
    public class WishlistItem
    {
        public int Id { get; set; }

        public int WishlistId { get; set; }

        public int ProductId { get; set; }

        public IEnumerable<Product> Products { get; set;}
    }
}
