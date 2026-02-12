using FoodApp.FoodAppContext;

namespace FoodApp.Services.Implementations
{
    public class CustomerServices
    {
        ICustomerRepository customerRepository = new ICustomerRepository();
        IUserRepository userRepository = new IUserRepository();
        public Customer? RegisterCustomer(string email, string password,string fullName, string phoneNumber, string address)
        {
            var isExist = userRepository.IsExist(email);
            if(isExist == true)
            {
                return null;
            }
            User user = new User()
            {
                Id = FoodAppContext.Users.Count + 1,
                Email = email,
                PassWord = password,
                Role = " app_customer"
            };
            userRepository.AddUser(user);
            
            Customer customer = new Customer()
            {
                Id = FoodAppContext.Customers.Count + 1,
                FullName = fullName,
                Email = email,
                PhoneNumber = phoneNumber,
                Address = address,
            };
            customerRepository.AddCustomer(customer);
            return customer;
        }
        public List<Customer> GetCustomers()
        {
            var customer = customerRepository.GetCustomers();
            return customer;
        }
    }
}