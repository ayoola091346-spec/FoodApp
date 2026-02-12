using FoodApp.Models;

namespace FoodApp.Repositories.Interfaces
{
    public interface IEateryRepository
    {
         void AddEatery(Eatery eatery);
         Eatery? GetEatery(int id);
          List<Eatery> GetEateries();
          void DeleteEatery(Eatery eatery);
          int CountEatery();
         
    }
}