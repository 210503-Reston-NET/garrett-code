using System;
using RRModels;
using System.Collections.Generic;
namespace RRUI
{
    public class MainMenu : IMenu
    {
        public void Start()
        {
            bool repeat = true;
            do{
                Console.WriteLine("Welcome!");
                Console.WriteLine("[0] Add R");
                Console.WriteLine("[1] Add Review");
                Console.WriteLine("[2] exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":

                    break;
                    case "1":
                        ViewRestaurant();
                    break;
                    case "2":
                        Console.WriteLine("bye");
                        repeat = false;
                    break;
                    default:
                    Console.WriteLine("Choose valid option");
                    break;

                }
            } while(repeat);
            
        }

        private void ViewRestaurant(){
             Restaurant goodTaste = new Restaurant("pizza bucket" , "nowhere", "asdf");
          goodTaste.Reviews = new List<Review>{ 
              new Review{Rating = 5, Description = "ehhh"}, 
              new Review{Rating = 0, Description= "food poisoning"}
            };
          Console.WriteLine(goodTaste.ToString());
          foreach (Review review in goodTaste.Reviews)
          {
              Console.WriteLine(review.ToString());
          }
        }
    }
}