public class ListeningActivity : Activity
{
    private int _count;
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
    private void GetRandomprompt()
    {
        Random random = new Random();
        int index = 
    }

    public void RunActivity()
    {
        // Display the standard starting message and prompt for duration.
        DisplayStartMessage(); // like the others 

        // Get a random prompt and display it.
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.Write(_prompts[index]);
        // Give the user a countdown to prepare.
        CountDown(5);
        // Loop for the duration specified by the user.
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _time)
        {
            // Inside the loop, prompt the user for input.
            Console.WriteLine("List as many items you can until timer stops.");
            //https://chatgpt.com/g/g-p-68c870dd40588191bccd1f9442b39616-kat-homework/c/68e6846f-3f70-8325-9031-a68f18ff2698
            List<string> items = new List<string>(); // store user enteries 
            int counter = 0; //start at zero
            // Increment a counter each time the user enters an item.
            while (true)
            {
                Console.WriteLine("Start.");
                string input = Console.ReadLine();
                //add to list 
                items.Add(input);
                counter++;
            }

            // After the loop finishes, display the total number of items entered.
                Console.WriteLine($"You entered{counter}. Great Job!");
            // Display the standard finishing message.
                DisplayEndMessage();
        }
    }
}