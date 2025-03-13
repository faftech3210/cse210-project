using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Random random = new Random();

        // List of prompts
        string[] prompts = 
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "what is my greatest achievement today?",
            "Who among the people i met today add value to my life?",
            "What are three things that brought me joy today",
            "What was the most unexpected lesson I learned today?",
            "How did I make a positive impact on someone's life today?",
            "What is one moment I felt truly present and alive today?",
            "What is something I did today that made me proud?",
            "How did I overcome a challenge or obstacle today?",
            "Which conversation or experience today made me feel grateful?",
            "What is a small but significant way I showed kindness today?",
            "Which of my talents or skills did I use or develop today?",
            "What made me laugh or smile the most today?",
            "What is one thing I would like to carry forward from today into tomorrow?",
        };

        int choice = -1;

        while (choice != 5)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // Write a new entry
                    string prompt = prompts[random.Next(prompts.Length)];
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    myJournal.AddEntry(prompt, response);
                    break;

                case 2: // Display the journal
                    myJournal.Display();
                    break;

                case 3: // Save the journal to a file
                    Console.Write("Enter the filename to save to: ");
                    string saveFilename = Console.ReadLine();
                    myJournal.SaveToFile(saveFilename);
                    break;

                case 4: // Load the journal from a file
                    Console.Write("Enter the filename to load from: ");
                    string loadFilename = Console.ReadLine();
                    myJournal.LoadFromFile(loadFilename);
                    break;

                case 5: // Exit
                    Console.WriteLine("Great job today! remember to write in your journal tomorrow");
                    break;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}