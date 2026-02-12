using FoodApp.Services.Implementations;
using FoodApp.Services.Interfaces;

namespace FoodApp.Menu
{
    public class DeleiveryManMenu
    {
        IOrderService orderService = new OrderService();

        public void DeliveryManStart()
        {
            Console.WriteLine("1. To View Order\n# To. Exist");

            string input = Console.ReadLine();
            if (input == "1")
            {
                ViewOrder();
                DeliveryManStart();
            }
            else if(input == "#")
            {
                
            }
        }
        public void ViewOrder()
        {
            var order = orderService.ViewOrders();
            foreach (var item in order)
            {
                Console.WriteLine($"{item.Id}\n{item.CustomerId}");
            }
        }

    }
}