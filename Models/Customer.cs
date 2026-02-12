using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Models
{
    public class Customer
    {
        public int Id {get;set;}
        public string  FullName {get;set;} = default!;
        public string  Email {get;set;} = default!;
        public string  Address {get;set;} = default!;
        public string  PhoneNumber {get;set;} = default!;

    }
}