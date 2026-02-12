using FoodApp.Models;

namespace FoodApp.Context
{
    public class FoodContext
    {
        public static List<Category> Categories = new ();
        public static List<Food> Foods = new ();

        //writeToFile

        public const string CategoryFie = @"C:\Users\Dell\OneDrive\Desktop\proj\FoodApp\Category.txt";
        public const string FoodFie = @"C:\Users\Dell\OneDrive\Desktop\proj\FoodApp\Food.txt";

    }
}