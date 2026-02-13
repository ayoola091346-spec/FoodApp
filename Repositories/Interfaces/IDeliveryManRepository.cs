using FoodApp.Models;

namespace FoodApp.Repositories.Interfaces
{
    public interface IDeliveryManRepository
    {
         
        void AddDeliveryMan(DeliveryMan deliveryMan);
        DeliveryMan? GetDeliveryMan(int id);
        List<DeliveryMan> GetDeliveryMen();
        void DeleteEatery(DeliveryMan deliveryMan);
        int CountDeliveryMan();
    }
}