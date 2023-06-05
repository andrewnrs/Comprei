using Comprei.Model.Entities.DefaultEntity;

namespace Comprei.Model.Entities
{
    public class ShoppingProduct : Entity
    {
        public Product? Product { get; set; }
        public int DesiredAmount { get; set; }
        public string? Observation { get; set; }
        public bool Bought { get; set; } = false;
    }
}
