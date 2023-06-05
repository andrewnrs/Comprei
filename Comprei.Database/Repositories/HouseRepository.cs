using Comprei.Database.Context;
using Comprei.Database.Repositories.RepositoryBase;
using Comprei.Model.Entities;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Comprei.Database.Repositories
{
    public class HouseRepository : Repository<House>
    {
        private readonly DbSet<House> Houses;
        private readonly DbSet<HouseStorage> HousesStorages;

        public HouseRepository(CompreiContext compreiContext) : base(compreiContext)
        {
            Houses = compreiContext.Set<House>();
            HousesStorages = compreiContext.Set<HouseStorage>();
        }

        public List<HouseStorage> GetAllByCustomerHouse(long houseId)
            => HousesStorages
            .Where(x => x.House.Id.Equals(houseId))
            .Include(x => x.Product)
            .ToList();
        
    }
}
