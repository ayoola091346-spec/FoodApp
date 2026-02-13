using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class DeliveryManRpository : IDeliveryManRepository
    {
        public void AddDeliveryMan(DeliveryMan deliveryMan)
        {
            FoodCoApp.DeliveryMen.Add(deliveryMan);
            string deliveryManFile = $"{deliveryMan.Id}\t{deliveryMan.FullName}\t{deliveryMan.UserId}\t{deliveryMan.PhoneNumer}";
            using(StreamWriter str = new StreamWriter(FoodCoApp.DeliveryManFile, true))
            {
                str.WriteLine(deliveryManFile);
            }


        }

        public void DeleteEatery(DeliveryMan deliveryMan)
        {
            FoodCoApp.DeliveryMen.Remove(deliveryMan);
        }

        public DeliveryMan? GetDeliveryMan(int id)
        {
            foreach(var item in FoodCoApp.DeliveryMen)
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
            return FoodCoApp.DeliveryMen;
        }
        public int CountDeliveryMan()
        {
            return FoodCoApp.DeliveryMen.Count;
        }

    }
}