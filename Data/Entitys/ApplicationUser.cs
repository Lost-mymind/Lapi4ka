using Microsoft.AspNetCore.Identity;

namespace Lapi4ka.Data.Entitys
{
    public class ApplicationUser:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ICollection<Adoption> AdoptionRequests { get; set; }
        public ICollection<Adoption> ProcessedRequests { get; set; }
    }
}
