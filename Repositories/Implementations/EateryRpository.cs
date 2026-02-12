using System.Runtime.CompilerServices;
using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class EateryRpository : IEateryRepository
    {
        public void AddEatery(Eatery eatery)
        {
           EateryContext.Eateries.Add(eatery);
           string stringEatery = $"{eatery.Id}\t{eatery.Name}\t{eatery.Email}\t{eatery.PhoneNumber}";
           using(StreamWriter str = new StreamWriter(EateryContext.EateryFile, true))
            {
                str.WriteLine(stringEatery);
            }
        }

        public void DeleteEatery(Eatery eatery)
        {
          EateryContext.Eateries.Remove(eatery);
        }

        public List<Eatery> GetEateries()
        {
            return EateryContext.Eateries;
        }

        public Eatery? GetEatery(int id)
        {
           foreach(var item in EateryContext.Eateries)
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
            return EateryContext.deliveryMen.Count;
        }

    }
}