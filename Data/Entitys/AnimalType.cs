using System.Collections;

namespace Lapi4ka.Data.Entitys
{
    public class AnimalType
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}
