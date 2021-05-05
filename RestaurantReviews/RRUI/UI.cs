using System;
using RRModels;
using System.Collections.Generic;
namespace RRUI
{
    class UI
    {
        static void Main(string[] args)
         {
             IMenu menu = new MainMenu();
             menu.Start();
        //   Console.WriteLine("Enter restaurant name");
        //   string name = Console.ReadLine();
        //   Restaurant goodTaste = new Restaurant("pizza bucket" , "nowhere", "asdf");
        //   goodTaste.Reviews = new List<Review>{ 
        //       new Review{Rating = 5, Description = "ehhh"}, 
        //       new Review{Rating = 0, Description= "food poisoning"}
        //     };
        //   Console.WriteLine(goodTaste.ToString());
        //   foreach (Review review in goodTaste.Reviews)
        //   {
        //       Console.WriteLine(review.ToString());
        //   }
        }
    }
}
