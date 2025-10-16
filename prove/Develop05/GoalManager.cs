
namespace GoalManager // learned this part from Microsoft
{
    public class GoalManager
    {
        // Attributes (private)
        // Constructors initializing the attributes
        private int _score;
        private readonly List<Goal> _goals = new List<Goal>();

        public void Start()
        {
            // Display the main menu and player info
            // Call one of the functions:
            // CreateGoal, ListGoalDetails, SaveGoals, LoadGoals, RecordEvent, etc.
            // Loop until quit
            // This is similar to the menu system from Develop 2 but with updates

            int menuNumber = 0;

            while (menuNumber != 6) // menu quits after 6
            {
                // TODO: Display menu options and handle user input here
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Create Goals");
                Console.WriteLine("2. List Goals");
                Console.WriteLine("3. Save Goals");
                Console.WriteLine("4. Load Goals");
                Console.WriteLine("5. Record Event");
                Console.WriteLine("6. Quit");
                Console.Write("Select a choice from the Menu: ");

                string userInput = Console.ReadLine();
                if (!int.TryParse(userInput, out menuNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Thread.Sleep(2000);
                    continue;
                }

                if (menuNumber == 1)
                {
                    // TODO: CreateGoal()
                    // Ask the user what type of goal (Simple/Eternal/Checklist)
                    // Ask for name, description, and points
                    // Create the goal and add it to the list
                    CreateAGoal();
                }
                else if (menuNumber == 2)
                {
                    // TODO: ListGoalDetails()
                    // Show all goals with their details
                    ListGoalDetail();
                }
                else if (menuNumber == 3)
                {
                    // TODO: SaveGoals()
                    // Save all goals to a file (include score at top)
                    SaveTheGoals();
                }
                else if (menuNumber == 4)
                {
                    // TODO: LoadGoals()
                    // Load goals from file and restore score
                    LoadTheGoals();
                }
                else if (menuNumber == 5)
                {
                    // TODO: RecordEvent()
                    // Display all goals with numbers
                    // Ask which one to record progress on
                    // Add the returned points from goal.RecordEvent() to _score
                    RecordEvent();
                }
                else if (menuNumber == 6)
                {
                    // Quit
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    // Any number not 1–6
                    Console.WriteLine("Invalid menu number. Try again.");
                }
            }
        }

        public void DisplayPlayerInfo()
        {
            // Display points
            Console.WriteLine($"{_score}");
        }

        public void ListGoalNames()
        {
            // Loop through the list of goals
            // Display the names
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals submitted");
                return;
            }

            for (int i = 0; i < _goals.Count; i++)
            {
                Goal goal = _goals[i];
                Console.WriteLine($"{i + 1} {goal.GetName()}");
            }
        }

        public void ListGoalDetail()
        {
            // Loop through the list of goals and display the full details
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals submitted");
                return;
            }

            for (int i = 0; i < _goals.Count; i++)
            {
                Goal goal = _goals[i];
                Console.WriteLine($"{i + 1} {goal.GetDetails()}");
            }
        }

        public void CreateAGoal()
        {
            // Display a submenu to select the goal type
            // Ask for the name, description, and points
            // Ask for more if they pick the checklist goal
            // Create the object and add to the goal list
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist");
            Console.Write("What type of goal would you like to make? ");
            string answer = Console.ReadLine();

            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What's a short description of it?");
            string description = Console.ReadLine();
            Console.WriteLine("What amount of points do you want for this goal?");
            int points = int.Parse(Console.ReadLine());

            if (int.TryParse(answer, out int answers))
            {

                // TODO: create the selected Goal type and add to _goals
                // e.g., _goals.Add(new SimpleGoal(name, desc, points));
                if (answers == 1)
                {
                    //got help from group member Evan for this part
                    _goals.Add(new SimpleGoal(name, description, points));
                    return;
                }
                else if (answers == 2)
                {
                    _goals.Add(new EternalGoal(name, description, points));
                    return;
                }
                else if (answers == 3)
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    return;
                }
                else
                {
                    Console.Write("Invalid input");
                }
            }
        }

        public void RecordEvent()
        {
            // Display a list of all goal names
            // Ask user to select a goal
            // Call the RecordEvent method on the correct goal
            // Update the goal based on points
            // Display how many points you have
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals submitted");
                return;
            }

            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1} {_goals[i].GetDetails()}");
            }

            Console.Write("Which goal did you achieve? ");
            if (!int.TryParse(Console.ReadLine(), out int select) || select < 1 || select > _goals.Count)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            Goal selectedGoal = _goals[select - 1];
            int pointsEarned = selectedGoal.RecordEvent();

            _score += pointsEarned; // add to total score

            Console.WriteLine($"Points earned: {pointsEarned}. Total score: {_score}");
        }

        public void SaveTheGoals()
        {
            // Ask user for a file name
            // Loop through each goal
            // Convert each goal to a string and save the string
            Console.Write("What is the file name? ");
            string fileName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("Invalid file name.");
                return;
            }

            // Example save format:
            // First line: SCORE|<score>
            // Then one line per goal via Goal.GetstringRepresent()
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                outputFile.WriteLine($"SCORE|{_score}");

                foreach (Goal g in _goals)
                {
                    // TODO: ensure each Goal implements GetstringRepresent()
                    outputFile.WriteLine(g.GetstringRepresent());
                }
            }

            Console.WriteLine("Goals saved.");
        }

        public void LoadTheGoals()
        {
            // Ask user for a file name
            // Read each line of the file and split it up
            // Use the parts to recreate the goal object
            Console.Write("What is the File Name? ");
            string fileName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(fileName) || !File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(fileName);
            _goals.Clear();

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                // Example expected lines:
                // SCORE|123
                // Simple|name|description|points|isComplete
                // Eternal|name|description|points
                // Checklist|name|description|points|current|target|bonus
                string[] parts = line.Split('|');

                if (parts.Length == 0) continue;

                if (parts[0] == "SCORE")
                {
                    // Restore score
                    if (parts.Length >= 2 && int.TryParse(parts[1], out int fileScore))
                    {
                        _score = fileScore;
                    }
                    continue;
                }

                // TODO: Recreate goals based on type in parts[0]
                // Example switch:
                // switch (parts[0])
                // {
                //     case "Simple":
                //         _goals.Add(SimpleGoal.FromParts(parts));
                //         break;
                //     case "Eternal":
                //         _goals.Add(EternalGoal.FromParts(parts));
                //         break;
                //     case "Checklist":
                //         _goals.Add(ChecklistGoal.FromParts(parts));
                //         break;
                // }
                if (parts[0] == "SimpleGoal")
                {
                    _goals.Add(SimpleGoal.FromParts(parts));
                    //         break;
                }
                else if (parts[0] == "EternalGoal")
                {
                    _goals.Add(EternalGoal.FromParts(parts));
                    //         break;
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    _goals.Add(ChecklistGoal.FromParts(parts));
                    //         break;
                    // }
                }


            }

            Console.WriteLine("Goals loaded.");
        }
    }
}
//https://gemini.google.com/app/1c31e83a81e826c9?_gl=1*9xwabs*_gcl_aw*R0NMLjE3NTg4MjE0OTYuQ2owS0NRancwTlBHQmhDREFSSXNBR0F6cHAwX2hXT2tJSE1KV1JDVTNpWDNsQkJIRG1fNE9wOXNFdmV2V1A1OWg2U1k5RjVBaWxYVFRSc2FBbThNRUFMd193Y0I.*_gcl_dc*R0NMLjE3NTg4MjE0OTYuQ2owS0NRancwTlBHQmhDREFSSXNBR0F6cHAwX2hXT2tJSE1KV1JDVTNpWDNsQkJIRG1fNE9wOXNFdmV2V1A1OWg2U1k5RjVBaWxYVFRSc2FBbThNRUFMd193Y0I.*_gcl_au*OTUwNjIxNDgxLjE3NTg4MjE0OTYuMTYzNTQ4MDkxLjE3NTg4MjE5OTAuMTc1ODgyMTk4OQ..*_ga*MTA2MjIzODcyMC4xNzU4ODIxNDk2*_ga_WC57KJ50ZZ*czE3NTg4MjE0OTYkbzEkZzEkdDE3NTg4MjE5OTMkajU2JGwwJGgw