using FoodApp.Models;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class UserRepository: IUserRepository
    {
        public void Add(User user)
        {
            FoodCoApp.Users.Add(user);

            string userFile = $"{user.Id}\t{user.email}\t{user.passWord}\t{user.Role}";
            using (StreamWriter streamWriter = new StreamWriter(FoodCoApp.userFile, true))
            {
                streamWriter.WriteLine(userFile);
            }
        }

        public User? GetUser(string email)
        {
             foreach (var item in FoodCoApp.Users)
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
            foreach(var item in FoodCoApp.Users) 
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