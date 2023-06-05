using Comprei.Database.Context;
using Comprei.Database.Repositories.RepositoryBase;
using Comprei.Model.Entities;
using System.Data.Entity;
using System.Linq;

namespace Comprei.Database.Repositories
{
    public class CustomerRepository : Repository<Customer>
    {
        private DbSet<Customer> customers;

        public CustomerRepository(CompreiContext compreiContext) : base(compreiContext)
        {
            customers = compreiContext.Set<Customer>();
        }

        public bool ValidateLogin(string login, string password)
            => customers.Where(x => x.Login.Equals(login) && x.Password.Equals(password)).Any();

    }
}
