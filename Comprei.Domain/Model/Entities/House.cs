using Comprei.Model.Entities.DefaultEntity;
using System.ComponentModel.DataAnnotations;

namespace Comprei.Model.Entities
{
    public class House : Entity
    {
        [StringLength(40, MinimumLength = 3)]
        public string? Nickname { get; set; }

        public Address? Address { get; set; }

        public List<HouseStorage>? Storage { get; set; }

        public List<Customer>? Customers { get; set; }
    }
}
