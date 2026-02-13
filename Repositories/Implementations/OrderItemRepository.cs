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
            FoodCoApp.OrderItems.Add(orderItem);
            string orderItems = $"{orderItem.Id} \t{orderItem.OrderId} \t{orderItem.FoodId}";
            using (StreamWriter str = new StreamWriter(FoodCoApp.OrderItemFile))
            {
                str.WriteLine(orderItems);
            }

        }

        public void DeleteOrderitem(OrderItem orderItem)
        {
            FoodCoApp.OrderItems.Remove(orderItem);
        }

        public OrderItem? GetOrderItem(OrderItem orderItem)
        {
            return orderItem;
        }

        public List<OrderItem> GetOrderItems()
        {
            return FoodCoApp.OrderItems;
        }

        public bool isExist(int id)
        {
            foreach (var item in FoodCoApp.OrderItems)
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