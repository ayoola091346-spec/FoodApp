using FoodApp.Models;
using FoodApp.Repositories.Implementations;
using FoodApp.Services.Interfaces;

namespace FoodApp.Services.Implementations
{
    public class UserServices: IUserServices
    {
        UserRepository userRepository = new UserRepository();
        public User? Login(string email, string passWord)
        {
           var user = userRepository.GetUser(email);
            
            if(user == null)
            {
                return null;
            }
            if(user.PassWord != passWord)
            {
                return null;
            }

            return user;  
        }

    }
}