using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Models
{
    public class DeliveryMan
    {
        public int Id {get;set;}
        public int UserId {get;set;}
        public string  FullName {get;set;} = default!;
        public string  PhoneNumer {get;set;} = default!;
    }
}