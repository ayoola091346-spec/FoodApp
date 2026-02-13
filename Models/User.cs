using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Models
{
    public class User
    {
        public int Id {get;set;}
        public string Email {get;set;} = default!;
        public string PassWord {get;set;} = default!;
        public string Role {get;set;} = default!;
    }
}