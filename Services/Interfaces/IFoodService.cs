using FoodApp.Models;

namespace FoodApp.Services.Interfaces
{
    public interface IFoodService
    {
         Food? CreateFood( int categoryId, string name, double price);
         List<Food> GetAllFood();
    }
}