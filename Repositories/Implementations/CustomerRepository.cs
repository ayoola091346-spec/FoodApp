using FoodApp.FoodAppContext;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class CustomerRepository: ICustomerRepository
    {
        public void AddCustomer(Customer customer)
        {
            FoodAppContext.Customers.Add(customer);
        }
        public Customer? GetCustomer(string email)
        {
            foreach (Customer item in FoodAppContext.Customers)
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
            return FoodAppContext.Customers;
        }
        public Customer? GetCustomers(string email)
        {
            foreach (Customer item in FoodAppContext.Customers)
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
           FoodAppContext.Customers.Remove(customer);
        }
    
    }
}
