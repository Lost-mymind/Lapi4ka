namespace Lapi4ka.Data.Entitys
{
    public class Adoption
    {
        public string Id { get; set; }
        public string AdopterId { get; set; }
        public string EmployeeId { get; set; }
        public string AnimalId { get; set; }
        public string Messege { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Animal Animal { get; set; }
        public ApplicationUser Adopter { get; set; }
        public ApplicationUser Employee { get; set; }
    }
}
