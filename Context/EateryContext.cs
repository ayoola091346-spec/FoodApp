using FoodApp.Models;
namespace FoodApp.Context
{
    public class EateryContext
    {
         public  static List<Eatery> Eateries = new();
         public static List<DeliveryMan> deliveryMen = new();

        public const String EateryFile = $"C:\\Users\\Dell\\OneDrive\\Desktop\\project\\Database\\User.txt";
          public const String DeliveryManFile = $"C:\\Users\\Dell\\OneDrive\\Desktop\\project\\Database\\Booking.txt";
    }
}