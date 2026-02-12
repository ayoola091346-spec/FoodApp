namespace FoodApp.Services.Interfaces
{
    public interface IUserServices
    {
        User? Login(string email, string passWord);
    }
}