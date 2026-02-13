using System.Runtime.CompilerServices;
using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class EateryRpository : IEateryRepository
    {
        public void AddEateries(Eatery eatery)
        {
           FoodCoApp.Eateries.Add(eatery);
           string eateriesFile = $"{eatery.Id}\t{eatery.Name}\t{eatery.Email}\t{eatery.PhoneNumber}";
           using(StreamWriter str = new StreamWriter(FoodCoApp.EateryFile, true))
            {
                str.WriteLine(eateriesFile);
            }
        }

        public void DeleteEatery(Eatery eatery)
        {
          FoodCoApp.Eateries.Remove(eatery);
        }

        public List<Eatery> GetEateries()
        {
            return FoodCoApp.Eateries;
        }

        public Eatery? GetEatery(int id)
        {
           foreach(var item in FoodCoApp.Eateries)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }
           return null;
        }
        public int CountEatery()
        {
            return FoodCoApp.DeliveryMen.Count;
        }

    }
}