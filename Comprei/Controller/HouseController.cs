using Comprei.Database.Repositories;
using Comprei.Model.Entities;

namespace Comprei.Controller
{
    public class HouseController
    {
        private readonly HouseRepository _houseRepository;

        public HouseController(HouseRepository houseRepository)
        {
            _houseRepository = houseRepository;
        }

        public List<HouseStorage> GetHouseStorage(long houseId)
        {
            return _houseRepository.GetAllByCustomerHouse(houseId);
        }
    }
}
