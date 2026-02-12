using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.Models;

namespace FoodApp.Context
{
    public class OrderContext
    {

        public static List<OrderItem> OrderItems = new();
        public static List<Order> Orders = new();
        public const string OrderItemFile = @"C:\Users\pc\Desktop\Foodapp\OrderItem.txt";
        public const string OrderFile = @"C:\Users\pc\Desktop\Foodapp\Order.txt";

    }
}