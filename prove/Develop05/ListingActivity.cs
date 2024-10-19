public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt proud of yourself recently?",
        "Who are some of your personal heroes?"
    };

    private int _count; 

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 60;
    }

    public override void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.WriteLine("Start listing items... (Press Enter after each item)");

        _count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                _count++;
            }
        }

        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
    }
}
