public class ListeningActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        // Add prompts here as per the instructions.
    };

    public ListeningActivity()
    {
        // Set the activity name and description in the constructor.
        _activity = "Listening Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void RunActivity()
    {
        // Display the standard starting message and prompt for duration.

        // Get a random prompt and display it.

        // Give the user a countdown to prepare.

        // Loop for the duration specified by the user.
        // Inside the loop, prompt the user for input.
        // Increment a counter each time the user enters an item.

        // After the loop finishes, display the total number of items entered.

        // Display the standard finishing message.
    }
}