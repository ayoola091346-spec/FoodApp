using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class FoodRepository : IFoodRepository
    {
        public void AddFood(Food food)
        {
            FoodCoApp.Foods.Add(food);
            string foodFile = $"{food.Id} \t{food.Name} \t{food.CategoryId} \t{food.Price}";
            using (StreamWriter str = new StreamWriter(FoodCoApp.FoodFile))
            {
                str.WriteLine(foodFile);
            }
        }

        public void DeleteFood(Food food)
        {
            FoodCoApp.Foods.Remove(food);
        }

        public int FoodCount()
        {
            return FoodCoApp.Foods.Count + 1;
        }


        public bool FoodExist(string name)
        {
            foreach(Food item in FoodCoApp.Foods)
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
            return FoodCoApp.Foods;
        }

        public Food? GetCategoryById(int id)
        {
            foreach(Food item in FoodCoApp.Foods)
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