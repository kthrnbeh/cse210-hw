using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        int menuNumber = 0;
        while (menuNumber != 4)
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflection Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out menuNumber))
            {
                Console.WriteLine("Invalid input. Please enter a number from the menu.");
                continue;
            }

            Console.WriteLine();

            switch (menuNumber)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Run();
                    break;
                case 3:
                    ListeningActivity listeningActivity = new ListeningActivity();
                    listeningActivity.Run();
                    break;
                case 4:
                    Console.WriteLine("Quit selected. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select an option from the menu.");
                    break;
            }
        }
    }
}
