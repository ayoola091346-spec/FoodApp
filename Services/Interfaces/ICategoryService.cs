using FoodApp.Models;

namespace FoodApp.Services.Interfaces
{
    public interface ICategoryService
    {
         Category? CreateCategory(string name, string description);
         List<Category> GetAllCategory();
    }
}