namespace FoodApp.Repositories.Interfaces
{
    public interface IUserRepository
    {
        bool IsExist(string email);

        void Add(User user);

        User? GetUser(string email);
        
        int UsersCount();
    }
}