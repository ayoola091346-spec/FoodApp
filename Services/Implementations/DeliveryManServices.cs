using FoodApp.Models;
using FoodApp.Repositories.Implementations;
using FoodApp.Repositories.Interfaces;
using FoodApp.Services.Interfaces;

namespace FoodApp.Services.Implementations
{
    public class DeliveryManServices : IDeliveryManServices
    {
       IDeliveryManRepository deliveryManRepository = new DeliveryManRpository();
        public DeliveryMan RegisterDeliveryman(int id, int userId, string fullName, string PhoneNumer)
        {
            DeliveryMan deliveryMan = new DeliveryMan()
            {
                Id = deliveryManRepository.CountDeliveryMan() +1,
                UserId = userId,
                FullName = fullName,
                PhoneNumer = PhoneNumer
            };
            deliveryManRepository.AddDeliveryMan(deliveryMan);
            return deliveryMan;

        }

        public List<DeliveryMan> ViewDeliveryMen()
        {
           var deliveryMan = deliveryManRepository.GetDeliveryMen();
           return deliveryMan;
        }

    }
}