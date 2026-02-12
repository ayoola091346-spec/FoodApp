using FoodApp.Models;

namespace FoodApp.Services.Interfaces
{
    public interface ICustomerServices
    {
        Customer? RegisterCustomer(string fullName, string Email, string phoneNumber, string address);
        List<Customer> GetCustomers();
    }
}