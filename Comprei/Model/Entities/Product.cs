using Comprei.Model.Entities.DefaultEntity;
using System.ComponentModel.DataAnnotations;

namespace Comprei.Model.Entities
{
    public class Product : Entity
    {
        [StringLength(120, MinimumLength = 3)]
        public string Name { get; set; }
        public string Description { get; set; }
        public long? Barcode { get; set; }
        public string? Picture { get; set; }
    }
}
