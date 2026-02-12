using FoodApp.Services.Interfaces;

namespace FoodApp.Menu
{
    public class MainMenu
    {
        ICategoryServices categoryServices = new ICategoryServices();
        IUserServicves userServicves = new IUserServicves();
        ICustomerServices customerServices = new ICustomerServices();
        IEateryServices eateryServices = new IEateryServices();
        IFoodService foodService = new IFoodService();

        public string Start()
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

            var response = customerServices.RegisterCustomer(email,passWord,name,phoneNumber,address);
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

            var response = userServicves.Login(email, passWord);
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