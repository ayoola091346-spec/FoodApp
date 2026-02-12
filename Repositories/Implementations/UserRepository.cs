using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class UserRepository: IUserRepository
    {
         public void Add(User user)
        {
            FoodAPPContext.Users.Count();
        }

        public User? GetUser(string email)
        {
             foreach (var item in FoodAPPContext.Users)
            {
                if(item.Email == email)
                {
                    return item;
                }
            }
            return null;
        }

        public bool IsExist(string email)
        {
            foreach(var item in FoodAPPContext.Users) 
            {
                if(item.Email == email)
                {
                    return true;
                }
            }
            return false;
        }

        public int UsersCount()
        {
           return FoodAPPContext.Users.Count;
        }
    }
}