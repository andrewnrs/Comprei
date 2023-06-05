using Comprei.Database.Context;
using Comprei.Database.Repositories.RepositoryBase;
using Comprei.Model.Entities;
using System.Data.Entity;
using System.Linq;

namespace Comprei.Database.Repositories
{
    public class CustomerRepository : Repository<Customer>
    {
        private readonly DbSet<Customer> Customers;

        public CustomerRepository(CompreiContext compreiContext) : base(compreiContext)
        {
            Customers = compreiContext.Set<Customer>();
        }

        public bool ValidateLogin(string login, string password)
            => Customers.Where(x => x.Login.Equals(login) && x.Password.Equals(password)).Any();

    }
}
