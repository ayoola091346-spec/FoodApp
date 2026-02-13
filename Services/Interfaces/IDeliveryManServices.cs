using FoodApp.Models;

namespace FoodApp.Services.Interfaces
{
    public interface IDeliveryManServices
    {
         DeliveryMan? RegisterDeliveryman( int userId, string fullName, string PhoneNumber);
         List<DeliveryMan> ViewDeliveryMen();
    }
}