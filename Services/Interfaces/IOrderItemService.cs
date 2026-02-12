using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.Models;

namespace FoodApp.Services.Interfaces
{
    public interface IOrderItemService
    {
        OrderItem? CreateOrderItem(int id, int orderId, int foodId);
        void DeleteOrderitem(int id);
        void ViewOrderItem(int id);
        List<OrderItem> ViewOrderItems();

    }
}