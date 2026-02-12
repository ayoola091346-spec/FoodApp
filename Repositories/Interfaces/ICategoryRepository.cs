using FoodApp.Models;

namespace FoodApp.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
         void AddCategory(Category category);
         Category? GetCAtegoryById(int id);
         List<Category> GetAllCategory();
         bool CategoryExist(string name);
         void DeleteCategory(Category category);
         int CategoryCount();


        
    }
}