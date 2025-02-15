using System.ComponentModel.DataAnnotations;

namespace KisanBazaar.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string? Flat { get; set; }

        public string? BuildingName { get; set; }

        public string? Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }
        
        public string Country { get; set; }

        public string PinCode { get; set; } 

        public int UserId { get; set; }
        public AppUser User { get; set; }
    }
}
