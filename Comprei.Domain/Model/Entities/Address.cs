using Comprei.Model.Entities.DefaultEntity;
using System.ComponentModel.DataAnnotations;

namespace Comprei.Model.Entities
{
    public class Address : Entity
    {
        [StringLength(12, MinimumLength = 4)]
        public string? Zipcode { get; set; }

        public string? Street { get; set; }

        public string? District { get; set; }

        public string? Number { get; set; }

        public string? City { get; set; }

        public string? State { get; set; }
    }
}
