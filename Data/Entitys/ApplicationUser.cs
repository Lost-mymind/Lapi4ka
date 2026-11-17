using Microsoft.AspNetCore.Identity;

namespace Lapi4ka.Data.Entitys
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
