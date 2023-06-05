using Comprei.Database.Repositories;
using Comprei.Model.Entities;

namespace Comprei.Controller
{
    public class ShoppingListController
    {
        private readonly ShoppingListRepository _shoppingListRepository;

        public ShoppingListController(ShoppingListRepository shoppingListRepository)
        {
            _shoppingListRepository = shoppingListRepository;
        }

        public void CreateShoppingList(Customer customer)
        {
            var shoppingList = new ShoppingList(customer);

            _shoppingListRepository.Add(shoppingList);
            _shoppingListRepository.Save();
        }

        public void AddProduct(ShoppingList shoppingList, Product? product, int desiredAmount, string? observation)
        {
            shoppingList.ShoppingProducts.Add(new(product, desiredAmount, observation));

            _shoppingListRepository.Update(shoppingList);
            _shoppingListRepository.Save();
        }

        public void RemoveProduct(ShoppingList shoppingList, Product? product)
        {
            var shopProd = shoppingList.ShoppingProducts.Where(x => x.Product.Equals(product)).First();

            shoppingList.ShoppingProducts.Remove(shopProd);

            _shoppingListRepository.Update(shoppingList);
            _shoppingListRepository.Save();
        }

        public void StartShoppingList(ShoppingList shoppingList)
        {
            shoppingList.Status = Model.Entities.Enums.ShoppingStatus.Shopping;

            _shoppingListRepository.Update(shoppingList);
            _shoppingListRepository.Save();
        }

        public void CloseShoppingList(ShoppingList shoppingList)
        {
            shoppingList.Status = Model.Entities.Enums.ShoppingStatus.Concluded;

            _shoppingListRepository.Update(shoppingList);
            _shoppingListRepository.Save();
        }

        public List<ShoppingList> List(Customer customer)
        {
            return _shoppingListRepository.GetAll().ToList();
        }
    }
}
