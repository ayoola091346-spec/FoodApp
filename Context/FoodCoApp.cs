using FoodApp.Models;

namespace FoodApp.Context
{
    public class FoodCoApp
    {
        public static List<User> Users = new List<User>();
        public static List<Customer> Customers = new List<Customer>();
        public static List<Category> Categories = new List<Category>();
        public static List<Food> Foods = new List<Food>();
        public static List<OrderItem> OrderItems = new();
        public static List<Order> Orders = new();
        public static List<Eatery> Eateries = new();
        public static List<DeliveryMan> DeliveryMen = new List<DeliveryMan>();

        //  FilE
        public const string UserFile = @"C:\Users\mudat\OneDrive\Desktop\FoodApp\User.txt";
        public const string CustomerFile = @"C:\Users\mudat\OneDrive\Desktop\FoodApp\Customer.txt";
        public const string CategoryFie = @"C:\Users\mudat\OneDrive\Desktop\FoodApp\Category.txt";
        public const string FoodFie = @"C:\Users\mudat\OneDrive\DesktopFoodApp\Food.txt";
        public const string OrderItemFile = @"C:\Users\mudat\OneDrive\Desktop\Foodapp\OrderItem.txt";
        public const string OrderFile = @"C:\Users\mudat\OneDrive\Desktop\Foodapp\Order.txt";
        public const string EateryFile = @"C:\Users\mudat\OneDrive\Desktop\Foodapp\Eatery.txt";
        public const string DeliveryManFile = @"C:\Users\mudat\OneDrive\Desktop\Foodapp\Booking.txt";
    }
}