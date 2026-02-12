using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodApp.Models;

namespace FoodApp.Services.Interfaces
{
    public interface IOrderService
    {
        Order? CreateOrder( int custmerId, int deliveryManId, double amount);
        void DeleteOrder(int id);
        void ViewOrder(int id);
        List<Order> ViewOrders();


    }
}