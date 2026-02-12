using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.Context;
using FoodApp.Models;
using FoodApp.Repositories.Implementations;
using FoodApp.Services.Interfaces;

namespace FoodApp.Services.Implementations
{
    public class OrderItemService : IOrderItemService
    {
        OrderItemRepository orderItemRepository = new OrderItemRepository();

        public OrderItem? CreateOrderItem(int id, int orderId, int foodId)
        {
            bool exists = orderItemRepository.isExist(id);
            if (exists == true)
            {
                return null;
            }
            OrderItem orderItem = new OrderItem
            {
                Id = OrderContext.OrderItems.Count + 1,
                OrderId = orderId,
                FoodId = foodId,
            };
            orderItemRepository.AddOrderItem(orderItem);
            return orderItem;
        }

        public void DeleteOrderitem(int id)
        {
            OrderItem orderItem = new OrderItem();
            foreach (var item in OrderContext.OrderItems)
            {
                if (item.Id == id)
                {
                    Console.WriteLine("OrderItem is deleted successfully");
                }
                else
                {
                    Console.WriteLine("orderItem not found");
                }
            }
            orderItemRepository.DeleteOrderitem(orderItem);
        }

        public void ViewOrderItem(int id)
        {
            OrderItem orderItem = new OrderItem();
            foreach (var item in OrderContext.OrderItems)
            {
                if (item.Id == id)
                {
                    Console.WriteLine("  ");
                }
                else
                {
                    Console.WriteLine("OrderItem not found");
                }
            }
            orderItemRepository.GetOrderItem(orderItem);
        }

        public List<OrderItem> ViewOrderItems()
        {
            var orderItem = orderItemRepository.GetOrderItems();
            return orderItem;
        }
    }
}