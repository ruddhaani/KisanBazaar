using System.ComponentModel.DataAnnotations;

namespace KisanBazaar.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string ProductName {get; set;}

        public double ProductPrice { get; set; }

        public string ProductDescription { get; set; }

        public int ProductTypeId { get; set; }

        public ProductType ProductType { get; set; }

        public IEnumerable<ProductImages> ProductImages { get; set; }
    }
}
