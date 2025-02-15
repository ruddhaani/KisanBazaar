using System.ComponentModel.DataAnnotations;

namespace KisanBazaar.Models
{
    public class ProductImages
    {
        [Key]
        public int Id { get; set; }

        public string ProductImageUrl { get; set; }

        public int ProductId { get; set; }
    }
}
