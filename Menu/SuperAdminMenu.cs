using System.Security.Cryptography.X509Certificates;
using FoodApp.Services.Implementations;
using FoodApp.Services.Interfaces;

namespace FoodApp.Menu
{
    public class SuperAdminMenu
    {

        IEateryServices eateryServices = new EateryServices();
        IDeliveryManServices deliveryManServices = new DeliveryManServices();
        public void SuperAdmin()
        {
            Console.WriteLine("WELCOME SUPERADMIN  \n1. REGISTER EATARY \n2. VIEW ALL EATORY \n3. REGISTER  DELIVERYMAN \n4. VIEW ALL DELIVERY MAN \n5. GONTO MAINMENU");
            string option = Console.ReadLine()!;

            if (option == "1")
            {
                RegisterEatory();
                SuperAdmin();
            }
            else if (option == "2")
            {
                ViewAllHitory();
                SuperAdmin();
            }
            else if (option == "3")
            {
                RegisterDEliveryMen();
                SuperAdmin();
            }
            else if (option == "4")
            {
                ViewAllDeliveryMen();
                SuperAdmin();
            }
            else
            {
                
            }
        }



        public void RegisterEatory()
        {
            Console.Write("enter your compny name  :  ");
            string name  = Console.ReadLine();
            Console.WriteLine("enter your Email");
            string email  = Console.ReadLine();
            Console.WriteLine("enter your Address  :  ");
            string address  = Console.ReadLine();    
            Console.Write("enter your  phoneNum  :  ");
            string phoneNum  = Console.ReadLine();
            

            var registerEatory = eateryServices.CreateEatery(name, email, address, phoneNum );
            if (registerEatory == null)
            {
                Console.WriteLine("register failled");
            }
            else
            {
                Console.WriteLine("you have sucessfully register an hitory");
            }

        }
        

        public void ViewAllHitory()
        {
            var viewAllHitory = eateryServices.ViewEatries();
            foreach(var item in viewAllHitory)
            {
                Console.WriteLine($"{item.Id}  {item.Email} {item.Name} {item.Address} {item.PhoneNumber}");
            }
        }




        public void RegisterDEliveryMen()
        {
           
            Console.WriteLine("enter your Id");
            string userId  = Console.ReadLine(); 
             Console.Write("enter your compny name  :  ");
            string fullname  = Console.ReadLine(); 
            Console.Write("enter your  phoneNum  :  ");
            string phoneNum  = Console.ReadLine();
            

            var registerDeliveryMen= deliveryManServices.RegisterDeliveryman(userId,fullname,phoneNum );
            if (registerDeliveryMen == null)
            {
                Console.WriteLine("register failled");
            }
            else
            {
                Console.WriteLine("you have sucessfully register an hitory");
            }

        }







        public void ViewAllDeliveryMen()
        {
            var viewAllDeliveryMen = deliveryManServices.ViewDeliveryMen();
            foreach(var item in viewAllDeliveryMen)
            {
                Console.WriteLine($"{item.Id}  {item.UserId} {item.FullName} {item.PhoneNumer}");
            }
        }



 
    }
}