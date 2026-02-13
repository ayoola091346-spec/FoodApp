
using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Implementations;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Services.Implementations
{
    public class CustomerServices
    {
        CustomerRepository customerRepository = new CustomerRepository();
        UserRepository userRepository = new UserRepository();
        public Customer? RegisterCustomer(string email, string password,string fullName, string phoneNumber, string address)
        {
            var isExist = userRepository.IsExist(email);
            if(isExist == true)
            {
                return null;
            }
            User user = new User()
            {
                Id = FoodCoApp.Users.Count +1,
                Email = email,
                PassWord = password,
                Role = " app_customer"
            };
            userRepository.Add(user);
            
            Customer customer = new Customer()
            {
                Id = FoodCoApp.Customers.Count + 1,
                FullName = fullName,
                Email = email,
                PhoneNumber = phoneNumber,
                Address = address,
            };
            customerRepository.Add(customer);
            return customer;
        }
        public List<Customer> GetCustomers()
        {
            var customer = customerRepository.GetCustomers();
            return customer;
        }
    }
}