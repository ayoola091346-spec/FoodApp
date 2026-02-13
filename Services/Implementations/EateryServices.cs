using FoodApp.Models;
using FoodApp.Repositories.Implementations;
using FoodApp.Repositories.Interfaces;
using FoodApp.Services.Interfaces;

namespace FoodApp.Services.Implementations
{
    public class EateryServices : IEateryServices
    {
        IEateryRepository eateryRepository = new EateryRpository();


        public Eatery? CreateEatery( string name, string email, string address, string PhoneNumer)
        {
           Eatery eatery = new Eatery()
          {
                Id = eateryRepository.CountEatery() +1,
                Name = name,
                Email = email,
                Address = address,
                PhoneNumber = PhoneNumer
          };
          eateryRepository.AddEatery(eatery);
          return eatery;
        }


        public List<Eatery> ViewEatries()
        {
          var eatery = eateryRepository.GetEateries();
          return eatery;
        }

    }
}