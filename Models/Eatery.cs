using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Models
{
    public class Eatery
    {
        public int Id {get;set;}
        public string  Name {get;set;} = default!;
        public string  Email {get;set;} = default!;
        public string  Address {get;set;} = default!;
        public string  PhoneNumber {get;set;} = default!;
    }
}