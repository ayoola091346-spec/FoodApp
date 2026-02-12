using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Implementations;
using FoodApp.Repositories.Interfaces;
using FoodApp.Services.Interfaces;

namespace FoodApp.Services.Implementations
{
    public class FoodService : IFoodService
    {
        IFoodRepository foodRepository = new FoodRepository();
        public Food? CreateFood(int categoryId, string name,  double price)
        {
            var IsExist = foodRepository.FoodExist(name);
            {
                if (IsExist == true)
                {
                    return null;
                }
            }

            Food food = new Food()
            {
                Id = foodRepository.FoodCount(),
                CategoryId = categoryId,
                Name = name,
                Price = price,
                
            };
            foodRepository.AddFood(food);
            return food;

        }


        public List<Food> GetAllFood()
        {     
           return foodRepository.GetAllFood();         
        }

    }
}