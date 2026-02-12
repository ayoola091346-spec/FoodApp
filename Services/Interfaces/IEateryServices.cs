using FoodApp.Models;

namespace FoodApp.Services.Interfaces
{
    public interface IEateryServices
    {
        Eatery? CreateEatery(int id, string name, string email, string address, string PhoneNumer);
        List<Eatery> ViewEatries();
    }
}