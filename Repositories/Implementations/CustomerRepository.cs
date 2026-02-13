
using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class CustomerRepository: ICustomerRepository
    {
        public void Add(Customer customer)
        {
            FoodCoApp.Customers.Add(customer);
            string customerFile = $"{customer.FullName}\t{customer.Email}\t{customer.PhoneNumber}\t{customer.Address}";
            using (StreamWriter streamWriter = new StreamWriter(FoodCoApp.CustomerFile, true))
            {
                streamWriter.WriteLine(customerFile);
            }
        }
        public Customer? GetCustomer(string email)
        {
            foreach (Customer item in FoodCoApp.Customers)
            {
                if(item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }
        public List<Customer> GetCustomers()
        {
            return FoodCoApp.Customers;
        }
        public Customer? GetCustomers(string email)
        {
            foreach (Customer item in FoodCoApp.Customers)
            {
                if(item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }
        public void Delete(Customer customer)
        {
           FoodCoApp.Customers.Remove(customer);
        }
    
    }
}
