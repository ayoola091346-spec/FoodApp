using FoodApp.Models;

namespace FoodApp.Repositories.Interfaces
{
    public interface ICustomerRepository
    {  
        void Add (Customer customer);
        Customer? GetCustomer(string email);
        List<Customer> GetCustomers();
        Customer? GetCustomers(string email);
        void Delete (Customer customer);
    }
}