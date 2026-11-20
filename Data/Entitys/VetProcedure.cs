using Lapi4ka.Data.Constants;

namespace Lapi4ka.Data.Entitys
{
    public class VetProcedure
    {
        public VetProcedure()
        {
            Id = Guid.NewGuid().ToString();
        }
        public string Id { get; set; }
        public string AnimalId { get; set; }
        public ProcedureType ProcedureType { get; set; }
        public DateTime ExecutedAt { get; set; }
        public string VetName { get; set; }
        public string Note { get; set; }
        public Animal Animal { get; set; }
    }
}
