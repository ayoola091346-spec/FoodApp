using FoodApp.Models;

namespace FoodApp.Services.Interfaces
{
    public interface IDeliveryManServices
    {
         DeliveryMan RegisterDeliveryman(int id, int userId, string fullName, string PhoneNumber);
         List<DeliveryMan> ViewDeliveryMen();
    }
}