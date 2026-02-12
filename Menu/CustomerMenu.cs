using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;
using FoodApp.Services.Implementations;

namespace FoodApp.Menu
{
    public class CustomerMenu
    {
        public  void CustomerStart()
        {
            Console.WriteLine("Welcome \n Choose an option \n 1. View all categories\n 2. View all food\n 3. Make an order\n 4. MainMenu");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                ViewCategories();
                break;
                case "2":
                ViewAllFood();
                break;
                case "3":
                MakeOrder();
                break;
                case "4":
                
                break;

            }
        }
        public void ViewCategories()
        {
            CategoryService categoryService = new CategoryService();
            var categories = categoryService.GetAllCategory();
            foreach (var item in categories)
            {
                Console.WriteLine($"{item.Id}\n{item.Name}\n{item.EateryId}\n{item.Description}");
            }
            CustomerStart();
        }
        public void ViewAllFood()
        {
            FoodService foodService = new FoodService();
            var foods = foodService.GetAllFood();
            foreach (var item in foods)
            {
                Console.WriteLine($"{item.Id}\n{item.CategoryId}\n{item.Name}\n{item.Description}\n{item.Price}");
            }
            CustomerStart();
        }
        public void MakeOrder()
        {
            OrderService orderService = new OrderService();
            Console.WriteLine("Enter CustomerId");
            int customerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter DeliveryManId");
            int deliveryManId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Amount");
            double amount = double.Parse(Console.ReadLine());
            orderService.CreateOrder(customerId, deliveryManId, amount);
            Console.WriteLine("sucess");

        }

    }
}