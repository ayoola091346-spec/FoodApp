using System.Runtime.InteropServices;
using FoodApp.Models;

namespace FoodApp.Repositories.Interfaces
{
    public interface IFoodRepository
    {
         void AddFood(Food food);
         Food? GetCategoryById(int id);
         List<Food> GetAllFood();
         bool FoodExist(string name);
         void DeleteFood(Food food);
         int FoodCount();
    }
}