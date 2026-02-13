using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order order)
        {
            FoodCoApp.Orders.Add(order);
            string orders = $"{order.Id}\t{order.CustomerId}\t{order.DeliveryManId}\t{order.Amount}";
            using (StreamWriter str = new StreamWriter(FoodCoApp.OrderFile))
            {
                str.WriteLine(orders);
            }
        }

        public void DeleteOrder(Order order)
        {
            FoodCoApp.Orders.Remove(order);
        }

        public List<Order> GetOrders()
        {
            return FoodCoApp.Orders;
        }

        public Order? GetOrder(Order order)
        {
            return order;
        }

        public bool isExist(int id)
        {
            foreach (var item in FoodCoApp.Orders)
            {
                if (item.Id == id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}