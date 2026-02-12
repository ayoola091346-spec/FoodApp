using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class DeliveryManRpository : IDeliveryManRepository
    {
        public void AddDeliveryMan(DeliveryMan deliveryMan)
        {
            EateryContext.deliveryMen.Add(deliveryMan);
            string stringDeliveryMan = $"{deliveryMan.Id}\t{deliveryMan.FullName}\t{deliveryMan.UserId}\t{deliveryMan.PhoneNumer}";
            using(StreamWriter str = new StreamWriter(EateryContext.DeliveryManFile, true))
            {
                str.WriteLine(stringDeliveryMan);
            }


        }

        public void DeleteEatery(DeliveryMan deliveryMan)
        {
          EateryContext.deliveryMen.Remove(deliveryMan);
        }

        public DeliveryMan? GetDeliveryMan(int id)
        {
            foreach(var item in EateryContext.deliveryMen)
            {
                if(item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<DeliveryMan> GetDeliveryMen()
        {
          return EateryContext.deliveryMen;
        }
        public int CountDeliveryMan()
        {
            return EateryContext.deliveryMen.Count;
        }

    }
}