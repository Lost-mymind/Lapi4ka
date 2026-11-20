using Lapi4ka.Data.Constants;
using System.Collections;

namespace Lapi4ka.Data.Entitys
{
    public class Animal
    {
        public string Id { get; set; }
        public string TypeId { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public AnimalSex Sex { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public AnimalStatus Status { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Adoption> AdoptionRequests { get; set; }
        public AnimalType AnimalType { get; set; }

    }
}
