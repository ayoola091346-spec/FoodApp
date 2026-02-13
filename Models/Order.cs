using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Models
{
    public class Order
    {
        public int Id {get;set;}
        public int CustomerId {get;set;}
        public int? DeliveryManId {get;set;}
        public double Amount {get;set;}
    }
}