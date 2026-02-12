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
    public class OrderService : IOrderService
    {
        OrderRepository orderRepository = new OrderRepository();
        public Order? CreateOrder( int customerId, int deliveryManId, double amount)
        {
            Order order = new Order()
            {
                Id = OrderContext.Orders.Count + 1,
                CustomerId = customerId,
                DeliveryManId = deliveryManId,
                Amount = amount,
            };
            orderRepository.AddOrder(order);
            return order;
        }

        public void DeleteOrder(int id)
        {
            Order order = new Order();
            foreach(var item in OrderContext.Orders)
            {
                if(item.Id == id)
                {
                    Console.WriteLine("Order deleted successfully");
                }
                else
                {
                    Console.WriteLine("Order not found");
                }
            }
            orderRepository.DeleteOrder(order);
        }

        public void ViewOrder(int id)
        {
            Order order = new Order();
            foreach(var item in OrderContext.Orders)
            {
                if(item.Id == id)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("Order not found");
                }
            }
            orderRepository.GetOrder(order);
        }

        public  List <Order> ViewOrders()
        {
            var order = orderRepository.GetOrders();
            return order;
        }
    }
}