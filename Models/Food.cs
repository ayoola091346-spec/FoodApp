using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Models
{
    public class Food
    {
        public int Id {get;set;}
        public int  CategoryId {get;set;} 
        public string  Name {get;set;} = default!;
        public string  Description {get;set;} = default!;
        public double Price {get;set;}
    }
}