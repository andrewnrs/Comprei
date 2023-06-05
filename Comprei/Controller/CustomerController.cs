using Comprei.Database.Repositories;
using Comprei.Model.Entities;
using Microsoft.VisualBasic.Logging;

namespace Comprei.Controller
{
    public class CustomerController
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerController(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void RegisterCustomer(string name, string login, string password, string houseNickname)
        {
            var customer = new Customer(name, login, password, houseNickname);

            _customerRepository.Add(customer);
            _customerRepository.Save();
        }

        public bool ValidateLogin(string login, string password)
        {
            return _customerRepository.ValidateLogin(login, password);
        }

        public List<Customer> List()
        {
            return _customerRepository.GetAll().ToList();
        }
    }
}
