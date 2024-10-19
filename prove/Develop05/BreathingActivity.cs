public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by guiding you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 60; 
    }

    public override void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration / 6; i++) 
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
        DisplayEndingMessage();
    }
}
