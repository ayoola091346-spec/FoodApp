using FoodApp.Services.Implementations;
using FoodApp.Services.Interfaces;

namespace FoodApp.Menu
{
    public class MainMenu
    {
        CustomerServices customerServices = new CustomerServices();
        UserServices userServices = new UserServices();
        public void Start()
        {
            Console.WriteLine("1. Register \n2. Login\n#.Exsit");
            string opt = Console.ReadLine();
            if (opt == "1")
            {
                RegisterMenu();
                Start();
            }
            else if(opt == "2")
            {
                LoginMenu();
                Start();
            }
            else if(opt == "#")
            {
                Console.WriteLine("Thanks");
                Start();
            }
            else
            {
                Console.WriteLine("invalid input");
                Start();
            }   
        }
         public void RegisterMenu()
        {
            Console.WriteLine("FullName: ");
            string fullName = Console.ReadLine();
            Console.WriteLine("PassWord: ");
            string passWord = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Address: ");
            string address = Console.ReadLine();
            Console.WriteLine("PhoneNumber: ");
            string phoneNumber = Console.ReadLine();

            var response = customerServices.RegisterCustomer(email,passWord,fullName,phoneNumber,address);
            if(response == null)
            {
                Console.WriteLine("Registration fail");
            }
            else
            {
                Console.WriteLine("Registration successful");
            }
        }
        public void LoginMenu()
        {
            Console.WriteLine("passWord");
            string passWord = Console.ReadLine()!;
            Console.WriteLine("Email");
            string email = Console.ReadLine()!;

            var response = userServices.Login(passWord, email);
            if (response == null)
            {
                Console.WriteLine("invalid credential");
            }
            else
            {
                Console.WriteLine("login successful");
            }
        } 
    }
}