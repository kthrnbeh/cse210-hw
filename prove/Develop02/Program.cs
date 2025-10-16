class Program
{

    static Journal journal = new Journal();
    static PromptGenerator promptGen = new PromptGenerator();


    static void Main(string[] args)
    {


        int menuNumber = 0;
        while (menuNumber != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out menuNumber))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.WriteLine();
                continue;
            }

            if (menuNumber == 1)
            {
                // ==== WRITE ====
                // TODO:
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                var e = new Entry
                {
                    _dateText = date,
                    _prompt = prompt,
                    _response = response, //fixed because of problem prompt

                };

                journal.AddEntry(e);
            }
            else if (menuNumber == 2)
            {
                // ==== DISPLAY ====
                // TODO: journal.DisplayAll();
                journal.DisplayAll();
            }
            else if (menuNumber == 3)
            {
                // ==== LOAD ====
                // TODO:
                // - Console.Write("Filename to load: ");
                // - string fileName = Console.ReadLine();
                // - journal.LoadFromFile(fileName);
                Console.Write("FileName to Load:");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (menuNumber == 4)
            {
                // ==== SAVE ====
                // TODO:
                // - Console.Write("Filename to save: ");
                // - string fileName = Console.ReadLine();
                // - journal.SaveToFile(fileName);
                Console.Write("Filename to Save:");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            else if (menuNumber == 5)
            {
                Console.WriteLine("Quit selected. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }

            Console.WriteLine();
        }
        //retry to save and turn in.... 
    }
}
//https://video.byui.edu/media/t/1_twcn0vdk/259941952