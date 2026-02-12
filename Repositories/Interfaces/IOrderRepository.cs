using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.Models;

namespace FoodApp.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        void AddOrder(Order order);
        List<Order> GetOrders();
        Order? GetOrder(Order order);
        void DeleteOrder(Order order);
        bool isExist(int id);

    }
}