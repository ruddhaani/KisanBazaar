using Microsoft.AspNetCore.Identity;

namespace KisanBazaar.Models
{
    public class AppRole : IdentityRole<int>
    {
        public IEnumerable<AppUserRole> UserRoles { get; set; }
    }
}
