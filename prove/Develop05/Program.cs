using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //create a goal manager object
        //call the start funciton on that object
        //create a list of goal objects
       // List<Goal> goals = new List<Goal>();
       // SimpleClass simple = new SimpleClass();
        //goals.Add(simple);
        //Goal goal = goals[0];
        Console.WriteLine("Hello Develop05 World!");
        //first step is to make a menu
        //Taking ideas from Develope 2 for the menu
        int menuNumber = 0;
        while (menuNumber != 4)
        {// found this to guide https://video.byui.edu/media/t/1_f4017z1d/259941952
         // my idea is to write a menu and have it keep going until it gets the number 5
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Start Breathing Activity");
            Console.WriteLine("2.Start Reflecting Activity");
            Console.WriteLine("3.Start Listening Activity");
            Console.WriteLine("4.Quit");

            Console.Write("Select a choice from the Menu ");

            string userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out menuNumber))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Thread.Sleep(2000);
                continue;
            }

            if (menuNumber == 1)
            {


                //what can I call

            }
            else if (menuNumber == 2)
            {



            }
            else if (menuNumber == 3)
            {




            }
            else if (menuNumber == 4)
            {
                Console.WriteLine("Quit selected. Goodbye!");
                Thread.Sleep(1000);
                break;
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                Thread.Sleep(1000);

            }

        }

    }
    //https://video.byui.edu/media/t/1_6lpgm7dz
    
  

}
    
