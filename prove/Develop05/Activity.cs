using System;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        // Constructor to initialize common attributes
    }

    public int Duration
    {
        get { return _duration; }
        set { _duration = value; } 
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"{_name} Activity");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {Duration} seconds.");
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); 
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed the {_name} activity for {Duration} seconds.");
        ShowSpinner(3); 
    }

    public void ShowSpinner(int seconds)
    {
        Console.Write("Starting in: ");
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(1000); 
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000); 
        }
    }

    public abstract void Run(); 
}