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
            FoodContext.Categories.Add(category);
            string CategoryFie = $"{category.Id} \t{category.Name} \t {category.Description}";
            using (StreamWriter str = new StreamWriter(FoodContext.CategoryFie))
            {
                str.WriteLine(CategoryFie);
            }
        }

        public int CategoryCount()
        {
            return FoodContext.Categories.Count + 1;
        }


        public bool CategoryExist(string name)
        {
            foreach (var item in FoodContext.Categories)
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
            FoodContext.Categories.Remove(category);
        }

        public List<Category> GetAllCategory()
        {
            return FoodContext.Categories;
        }

        public Category? GetCAtegoryById(int id)
        {
            foreach (var item in FoodContext.Categories)
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