public class GoalManager
{
    // Attributes (private)
    // Constructors initializing the attributes
    private string _name;
    private string _description;
    private int _points;

    public void Start()
    {
        // Display the main menu and player info
        // Call one of the functions:
        // CreateGoal, ListGoalDetails, SaveGoals, LoadGoals, RecordEvent, etc.
        // Loop until quit
        // This is similar to the menu system from Develop 2 but with updates

        int menuNumber = 0;

        while (menuNumber != 5) //menu quits after 6
        {
            // TODO: Display menu options and handle user input here
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Create Goals");
            Console.WriteLine("2.List Goals");
            Console.WriteLine("3.Save Goals");
            Console.WriteLine("4.Load Goals");
            Console.WriteLine("5.Recod Event");
            Console.WriteLine("6.Quit");
             string userInput = Console.ReadLine();

            if (!int.TryParse(userInput, out menuNumber))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Thread.Sleep(2000);
                    continue;
                }
        }
    }

    public void DisplayPlayerInfo()
    {
        // Display points
    }

    public void ListGoalNames()
    {
        // Loop through the list of goals
        // Display the names
        // You may need another function in the Goal class
    }

    public void ListGoalDetail()
    {
        // Loop through the list of goals and display
        // the full details
    }

    public void CreateAGoal()
    {
        // Display a submenu to select the goal type
        // Ask for the name, description, and points
        // Ask for more if they pick the checklist goal
        // Create the object and add to the goal list
    }

    public void RecordEvent()
    {
        // Display a list of all goal names
        // Ask user to select a goal
        // Call the RecordEvent method on the correct goal
        // Update the goal based on points
        // Display how many points you have
    }

    public void SaveTheGoals()
    {
        // Ask user for a file name
        // Loop through each goal
        // Convert each goal to a string and save the string
    }

    public void LoadTheGoals()
    {
        // Ask user for a file name
        // Read each line of the file and split it up
        // Use the parts to recreate the goal object
    }
}
