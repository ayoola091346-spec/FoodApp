using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class DeliveryManRpository : IDeliveryManRepository
    {
        public void AddDeliveryMan(DeliveryMan deliveryMan)
        {
            FoodCoApp.deliveryMen.Add(deliveryMan);
            string deliveryMan = $"{deliveryMan.Id}\t{deliveryMan.FullName}\t{deliveryMan.UserId}\t{deliveryMan.PhoneNumer}";
            using(StreamWriter str = new StreamWriter(FoodCoApp.DeliveryManFile, true))
            {
                str.WriteLine(deliveryMan);
            }


        }

        public void DeleteEatery(DeliveryMan deliveryMan)
        {
            FoodCoApp.deliveryMen.Remove(deliveryMan);
        }

        public DeliveryMan? GetDeliveryMan(int id)
        {
            foreach(var item in FoodCoApp.deliveryMen)
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
            return FoodCoApp.deliveryMen;
        }
        public int CountDeliveryMan()
        {
            return FoodCoApp.deliveryMen.Count;
        }

    }
}