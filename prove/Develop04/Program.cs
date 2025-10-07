using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello Develop04 World!");
    //first step is to make a menu
    //Taking ideas from Develope 2 for the menu
    int menuNumber = 0;
    while (menuNumber != 4)
    {
      // my idea is to write a menu and have it keep going until it gets the number 5
      Console.WriteLine("Menu Options:");
      Console.WriteLine("1.Start Breathing Activity");
      Console.WriteLine("2.Start Reflecting Activity");
      Console.WriteLine("3.Start Listening Activity");
      Console.WriteLine("4.Quit");

      Console.Write("Select a choice from the Menu ");

      string userInput = Console.ReadLine();
    }
  }

}