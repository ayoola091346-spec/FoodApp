using FoodApp.Models;
using FoodApp.Repositories.Implementations;
using FoodApp.Repositories.Interfaces;
using FoodApp.Services.Interfaces;

namespace FoodApp.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository categoryRepository = new CategoryRepository();
        public Category? CreateCategory(string name, string description)
        {
            var IsExist = categoryRepository.CategoryExist(name);
            {
                if (IsExist == true)
                {
                    return null;

                }
            }


            Category category = new Category
            {
                Id = categoryRepository.CategoryCount(),
                Name = name,
                Description = description,
            };
            categoryRepository.AddCategory(category);
            return category;
        }

        public List<Category> GetAllCategory()
        {
            return categoryRepository.GetAllCategory();
        }
   

    }
}