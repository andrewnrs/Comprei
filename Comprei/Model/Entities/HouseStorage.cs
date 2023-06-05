using Comprei.Model.Entities.DefaultEntity;

namespace Comprei.Model.Entities
{
    public class HouseStorage : Entity
    {
        public House? House { get; set; }
        public Product? Product { get; set; }

        public int Quantity { get; set; }
        public string? Observation { get; set; }
    }
}
