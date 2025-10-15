public class GoalManager
{
    //Attributes(private)
    //constructors italizing the attributes

    public void Start
    {
        //Display the main menu and player info
        //call one of the funcitions
        //CreateGoal, listGoaldetails, Save Goals, Load Goals
        //Record Event, etc.. 

    }
    
    public void DisplayPlayerInfo
    {
        //Display points
    }
    public void ListGoalNames
    {
        //Loop through the list of goals
        //Display the names
        //you may need another function in the goal class
    }
    public void ListGoalDetail
    {
        //Loop through the list of goals and display
        //the full details


    }
    public void CreateAGoal
    {
        //Display a submenu to select the goal type
        //ask for the name description and points
        //ask for more if they pick the check list goal
        //Create the object and add to the goal list

    }
    public void RecordEvent
    {
        //we want to display a list of all of the goal names
        //ask user to select a goal
        //Call the record event on the correct goal
        //update the goal based on the point
        //Display how many points you have
    }
    public void SaveTheGoals
    {
        //ask user for a file name loop through goal
        //convert each goal to a string then save the string
    }
    public void LoadTheGoals
    {
        //Ask user for a file name
        //Read each line of the file and split it up
        //use the parts to recreate the goal object
    }
}