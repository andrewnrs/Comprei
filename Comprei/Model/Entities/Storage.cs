using Comprei.Model.Entities.DefaultEntity;
using System.ComponentModel.DataAnnotations;

namespace Comprei.Model.Entities
{
    public class Storage : Entity
    {
        public List<House>? House { get; set; }
        public List<Product>? Product { get; set; }

        public int Quantity { get; set; }
        public string? Observation { get; set; }

    }
}
