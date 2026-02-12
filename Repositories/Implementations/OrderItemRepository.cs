using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Interfaces;

namespace FoodApp.Repositories.Implementations
{
    public class OrderItemRepository : IOrderItemRepository
    {
        public void AddOrderItem(OrderItem orderItem)
        {
            OrderContext.OrderItems.Add(orderItem);
            string orderItems = $"{orderItem.Id} / {orderItem.OrderId} / {orderItem.FoodId}";
            using (StreamWriter str = new StreamWriter(OrderContext.OrderItemFile))
            {
                str.WriteLine(orderItems);
            }

        }

        public void DeleteOrderitem(OrderItem orderItem)
        {
            OrderContext.OrderItems.Remove(orderItem);
        }

        public OrderItem? GetOrderItem(OrderItem orderItem)
        {
            return orderItem;
        }

        public List<OrderItem> GetOrderItems()
        {
            return OrderContext.OrderItems;
        }

        public bool isExist(int id)
        {
            foreach (var item in OrderContext.OrderItems)
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