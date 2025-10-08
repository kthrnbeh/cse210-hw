using System;
using System.Collections.Generic;
using System.Threading;


class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Develop04 World!");
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
        continue;
      }

      if (menuNumber == 1)
      {
        BreathingActivity breathingActivity = new BreathingActivity();//new breathing activity
        breathingActivity.BreathingCycle();
        breathingActivity.CountDown(5);
        breathingActivity.StartMessageDisplay();
        breathingActivity.EndMessageDisplay();
        breathingActivity.StartSpinner(5);

        //what can I call

      }
      else if (menuNumber == 2)
      {
        ReflecionActivity reflecionActivity = new ReflecionActivity();
        reflecionActivity.DisplayPrompt();
        reflecionActivity.DisplayQuestion();
        reflecionActivity.StartMessageDisplay();
        reflecionActivity.EndMessageDisplay();
        reflecionActivity.GetRandomPrompt();
        reflecionActivity.GetRandomQuestion();
        reflecionActivity.StartActivity();
      }
      else if (menuNumber == 3)
      {
        ListeningActivity listeningActivity = new ListeningActivity();
        listeningActivity.StartMessageDisplay()
        listeningActivity.RunActivity();
        listeningActivity.EndMessageDisplay();


      }
      else if (menuNumber == 4)
      {
        Console.WriteLine("Quit selected. Goodbye!");
      }
      else
      {
        Console.WriteLine("Invalid Choice");
      }
      
    }
      
    }
    
  

}