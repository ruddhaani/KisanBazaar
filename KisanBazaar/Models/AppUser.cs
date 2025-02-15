using Microsoft.AspNetCore.Identity;

namespace KisanBazaar.Models
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<Address>? Address { get; set; }

        public IEnumerable<Order>? Orders { get; set; }

        public IEnumerable<AppUserRole> UserRoles { get; set; }

    }
}
