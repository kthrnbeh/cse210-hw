public class ListeningActivity : Activity
{

    private List<string> _prompts = new List<string>()
    {
        // Add prompts here as per the instructions.
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListeningActivity() : base("Listening Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        // Set the activity name and description in the constructor.
        //teacher said to use base here instead.
    }
    private string GetRandomprompt()//not void i do return... 
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public void RunActivity()
    {
        // Display the standard starting message and prompt for duration.
        DisplayStartMessage(); // like the others 
        Console.WriteLine($"{GetRandomprompt()}");
        Console.WriteLine("List as many items you can until timer stops.");
        CountDown(5);
        // Loop for the duration specified by the user.
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        int counter = 0; //I keep forgeting this from the video... oh I had it in the loop 
        while (DateTime.Now <endTime)
        {
            // Inside the loop, prompt the user for input.
            
            //https://chatgpt.com/g/g-p-68c870dd40588191bccd1f9442b39616-kat-homework/c/68e6846f-3f70-8325-9031-a68f18ff2698
            List<string> items = new List<string>(); // store user enteries 
            
            // Increment a counter each time the user enters an item.
            while (true)
            {
                //copying Breathing again
                if (DateTime.Now >= endTime)
                {
                    break; // stop!
                }
                counter++;
            }

            // After the loop finishes, display the total number of items entered.
                Console.WriteLine($"You entered{counter}. Great Job!");
            // Display the standard finishing message.
                DisplayEndMessage();
        }
    }
}