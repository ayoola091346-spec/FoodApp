using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class FoodRepository : IFoodRepository
    {
        public void AddFood(Food food)
        {
            FoodContext.Foods.Add(food);
            string FoodFie = $"{food.Id} {food.Name} {food.CategoryId} {food.Price}";
            using (StreamWriter str = new StreamWriter(FoodContext.FoodFie))
            {
                str.WriteLine(FoodFie);
            }
        }

        public void DeleteFood(Food food)
        {
            FoodContext.Foods.Remove(food);
        }

        public int FoodCount()
        {
            return FoodContext.Foods.Count + 1;
        }


        public bool FoodExist(string name)
        {
            foreach(Food item in FoodContext.Foods)
            {
                if (item.Name == name)
                {
                    return true;
                    
                }
            }
            return false;
        }

        public List<Food> GetAllFood()
        {
            return FoodContext.Foods;
        }

        public Food? GetCategoryById(int id)
        {
            foreach(Food item in FoodContext.Foods)
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