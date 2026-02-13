using System.Runtime.InteropServices;
using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        public void AddCategory(Category category)
        {
            FoodCoApp.Categories.Add(category);
            string categoryFile = $"{category.Id}\t{category.Name}\t{category.Description}";
            using (StreamWriter str = new StreamWriter(FoodCoApp.CategoryFile))
            {
                str.WriteLine(categoryFile);
            }
        }

        public int CategoryCount()
        {
            return FoodCoApp.Categories.Count + 1;
        }


        public bool CategoryExist(string name)
        {
            foreach (var item in FoodCoApp.Categories)
            {
                if (item.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void DeleteCategory(Category category)
        {
            FoodCoApp.Categories.Remove(category);
        }

        public List<Category> GetAllCategory()
        {
            return FoodCoApp.Categories;
        }

        public Category? GetCategoryById(int id)
        {
            foreach (var item in FoodCoApp.Categories)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        
        
    }
}