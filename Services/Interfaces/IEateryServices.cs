using FoodApp.Models;

namespace FoodApp.Services.Interfaces
{
    public interface IEateryServices
    {
        Eatery? CreateEatery( string name, string email, string address, string PhoneNumer);
        List<Eatery> ViewEatries();
    }
}