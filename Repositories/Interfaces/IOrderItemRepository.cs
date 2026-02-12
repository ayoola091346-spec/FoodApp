using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.Models;

namespace FoodApp.Repositories.Interfaces
{
    public interface IOrderItemRepository
    {
        void AddOrderItem(OrderItem orderItem);
        List<OrderItem> GetOrderItems();
        OrderItem? GetOrderItem(OrderItem orderItem);
        void DeleteOrderitem(OrderItem orderItem);
        bool isExist(int id);
    }
}