using System.ComponentModel.DataAnnotations;

namespace KisanBazaar.Models
{
    public class ProductType
    {
        [Key]
        public int Id {get; set;}

        public string Type { get; set; }
    }
}
