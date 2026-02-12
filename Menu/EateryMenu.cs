using System.Runtime.CompilerServices;
using FoodApp.Services.Implementations;
using FoodApp.Services.Interfaces;

namespace FoodApp.Menu
{
  public class EateryMenu
  {
    IFoodService foodService = new FoodService();
    ICategoryService categoryService = new CategoryService();
    public void EateryStart()
    {
      Console.WriteLine("1.To create Food\n2.To view Food\n3.To create Category\n4.To view Category\n#.To Exist");
      string input = Console.ReadLine();
      if (input == "1")
      {
        CreateFoodMenu();
        EateryStart();
      }
      if (input == "2")
      {
        ViewFood();
        EateryStart();
      }
      else if (input == "3")
      {
         CreateCategoryMenu();
         EateryStart();
      }
      else if (input == "4")
      {
          ViewCategoriesMenu();
          EateryStart();
      }
      
      else if (input == "#")
      {
            
      }

    }

    public void CreateFoodMenu()
    {
      Console.WriteLine("Entet The food categoryId");
      int categoryId = int.Parse(Console.ReadLine());
      Console.WriteLine("Entet The food name");
      string name = Console.ReadLine();
      Console.WriteLine("Entet The food price");
      double price = double.Parse(Console.ReadLine());
      foodService.CreateFood(categoryId, name, price);


    }
    public void ViewFood()
    {
      var food = foodService.GetAllFood();
      foreach (var item in food)
      {
        Console.WriteLine($"{item.Id}\n{item.CategoryId}\n{item.Name}\n{item.Description}\n{item.Price}");

      }
    }
    public void CreateCategoryMenu()
    {
       Console.WriteLine("Enter The Category Name");
       string Name = Console.ReadLine();
       Console.WriteLine("The Category Describtion");
       string Describtion = Console.ReadLine();
       categoryService.CreateCategory(Name, Describtion);

    }
    public void ViewCategoriesMenu()
    {
      var category = categoryService.GetAllCategory();
      foreach(var item in category)
      {
        Console.WriteLine($"{item.Id}\n{item.Name}\n{item.Description}\n{item.EateryId}");
      }
    }
  }
}