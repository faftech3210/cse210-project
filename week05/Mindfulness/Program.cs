using System;
namespace MindfulnessApp;

class Program
{
    static void Main(string[] args)
    {
        while (true)
            {
                Console.WriteLine("\nSelect an activity:");
                Console.WriteLine("1. Breathing Activity");
                Console.WriteLine("2. Reflection Activity");
                Console.WriteLine("3. Listing Activity");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                Activity activity = choice switch
                {
                    "1" => new BreathingActivity(),
                    "2" => new ReflectionActivity(),
                    "3" => new ListingActivity(),
                    "4" => null,
                    _ => throw new ArgumentException("Invalid choice!")
                };

                if (activity == null)
                    break;

                activity.Run();
            }
    }
}