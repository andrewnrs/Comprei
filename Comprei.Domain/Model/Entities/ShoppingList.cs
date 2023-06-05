using Comprei.Model.Entities.DefaultEntity;
using Comprei.Model.Entities.Enums;

namespace Comprei.Model.Entities
{
    public class ShoppingList : Entity
    {
        public ShoppingList(Customer customer)
        {
            Status = ShoppingStatus.Created;
            Customer = customer;
            ShoppingProducts = new();
        }

        public ShoppingStatus Status { get; set; }
        public Customer Customer { get; set; }
        public List<ShoppingProduct> ShoppingProducts { get; set; }
    }
}
