using System.Runtime.CompilerServices;
using System.Threading;
public class GoalManager
{
    // Attributes (private)
    // Constructors initializing the attributes
    private int _score;
    private List<Goal> _goals = new List<Goal>();
 

    public void Start()
    {
        // Display the main menu and player info
        // Call one of the functions:
        // CreateGoal, ListGoalDetails, SaveGoals, LoadGoals, RecordEvent, etc.
        // Loop until quit
        // This is similar to the menu system from Develop 2 but with updates

        int menuNumber = 0;

        while (menuNumber != 6) //menu quits after 6
        {
            // TODO: Display menu options and handle user input here
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Create Goals");
            Console.WriteLine("2.List Goals");
            Console.WriteLine("3.Save Goals");
            Console.WriteLine("4.Load Goals");
            Console.WriteLine("5.Recod Event");
            Console.WriteLine("6.Quit");
            Console.WriteLine("Select a choice from the Menu.");
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
                // Example:
                //   1. [ ] Read Scriptures — Read daily for strength (+100 points)
                //   2. [X] Run Marathon — Goal completed! (+1000 points)
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
        // You may need another function in the Goal class
        //ah like we have done before
        if(_goals.Count==0)
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
        // Loop through the list of goals and display
        // the full details
        //realized myself that it was similar
         if(_goals.Count==0)
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
        // Ask for name, description, and points
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2.Eternal Goal");
        Console.WriteLine("3. Checklist");
        Console.WriteLine("What type of goal would you like to make?");
        string answer = Console.ReadLine();
    }

    public void RecordEvent()
    {
        // Display a list of all goal names
        // Ask user to select a goal
        // Call the RecordEvent method on the correct goal
        // Update the goal based on points
        // Display how many points you have
        Console.WriteLine("please select a goal");
        Console.ReadLine();
        string filename = "goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
         string[] parts = line.Split(",");
        string firstName = parts[0];
        string lastName = parts[1];
        }
    }

    public void SaveTheGoals()
    {
        // Ask user for a file name
        // Loop through each goal
        // Convert each goal to a string and save the string
        Console.WriteLine("What is the file name?");
        Console.ReadLine();
    }

    public void LoadTheGoals()
    {
        // Ask user for a file name
        // Read each line of the file and split it up
        // Use the parts to recreate the goal object
        Console.WriteLine("What is the File Name?");
    }
}
//https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
//https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/polymorphism
//https://byui-cse.github.io/cse210-course-2023/unit05/prepare.html