using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class OrderRepository : IOrderRepository
    {
        public void AddOrder(Order order)
        {
            OrderContext.Orders.Add(order);
            string orders = $"{order.Id}/{order.CustomerId}/{order.DeliveryManId}/{order.Amount}";
            using (StreamWriter str = new StreamWriter(OrderContext.OrderFile))
            {
                str.WriteLine(orders);
            }
        }

        public void DeleteOrder(Order order)
        {
            OrderContext.Orders.Remove(order);
        }

        public List<Order> GetOrders()
        {
            return OrderContext.Orders;
        }

        public Order? GetOrder(Order order)
        {
            return order;
        }

        public bool isExist(int id)
        {
            foreach (var item in OrderContext.Orders)
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