class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ListingActivity();
                    break;
                case "3":
                    activity = new ReflectingActivity();
                    break;
                case "4":
                    return; 
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    System.Threading.Thread.Sleep(2000);
                    continue;
            }

            if (activity != null)
            {
                Console.Write("Enter the duration of the activity (in seconds): ");
                if (int.TryParse(Console.ReadLine(), out int duration))
                {
                    activity.Duration = duration; 
                    activity.Run();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    System.Threading.Thread.Sleep(2000);
                }
            }
        }
    }
}


/* 
Exceeding Requirements:
1. Randomized Prompts and Questions: 
   The listing and reflecting activities have lists of prompts and questions that are randomized during each session, ensuring that the experience remains fresh and varied.

2. Customizable Duration: 
   Users can input their own desired activity duration for more control over their mindfulness exercises, allowing them to set shorter or longer activities based on their schedules.
*/
