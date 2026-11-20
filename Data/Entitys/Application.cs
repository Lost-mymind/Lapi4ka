using Lapi4ka.Data.Constants;

namespace Lapi4ka.Data.Entitys
{
    public class Application
    {
        public Application()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string UserId { get; set; }
        public VolunteerActivity Activity { get; set; }
        public bool MondayFree { get; set; }
        public bool TuesdayFree { get; set; }
        public bool WednesdayFree { get;set; }
        public bool ThursdayFree { get;set;}
        public bool FridayFree { get; set; }
        public bool SaturdayFree { get;set; }
        public bool SundayFree { get;set; }
        public DateTime RequestedAt { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public ApplicationUser User { get; set; }
    }
}
