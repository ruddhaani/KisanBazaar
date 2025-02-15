using System.ComponentModel.DataAnnotations;

namespace KisanBazaar.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
