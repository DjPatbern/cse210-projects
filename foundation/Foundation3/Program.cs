class Program
{
    static void Main()
    {
        // Create activities
        var activities = new List<Activity>
        {
            new Running(new DateTime(2024, 10, 30), 30, 5.0),
            new Cycling(new DateTime(2024, 10, 30), 45, 15.0),
            new Swimming(new DateTime(2024, 10, 30), 25, 20)
        };

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
