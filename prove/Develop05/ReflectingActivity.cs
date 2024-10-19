public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What did you learn from this experience?",
        "What is your favorite thing about this experience?",
        "How can you apply what you learned from this experience in the future?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 60;
    }

    public override void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        for (int i = 0; i < _duration / 10; i++) 
        {
            GetRandomQuestion();
            ShowSpinner(5); 
        }
        DisplayEndingMessage();
    }

    private void GetRandomPrompt()
    {
        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
    }

    private void GetRandomQuestion()
    {
        Random random = new Random();
        Console.WriteLine(_questions[random.Next(_questions.Count)]);
    }
}
