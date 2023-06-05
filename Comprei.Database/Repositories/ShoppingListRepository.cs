using Comprei.Database.Context;
using Comprei.Database.Repositories.RepositoryBase;
using Comprei.Model.Entities;
using Comprei.Model.Entities.Enums;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Comprei.Database.Repositories
{
    public class ShoppingListRepository : Repository<ShoppingList>
    {
        private readonly DbSet<ShoppingList> ShoppingLists;
        private readonly DbSet<ShoppingProduct> ShoppingProduct;

        public ShoppingListRepository(CompreiContext compreiContext) : base(compreiContext)
        {
            ShoppingLists = compreiContext.Set<ShoppingList>();
        }


        public List<ShoppingList> GetByCustomerAndStatus(long customerId, ShoppingStatus shoppingStatus)
            => ShoppingLists
            .Where(x => x.Customer.Id.Equals(customerId) && x.Status.Equals(shoppingStatus))
            .Include(x => x.ShoppingProducts)
            .ToList();

    }
}
