using System;

class Program
{
    static void Main(string[] args)
    {
// Create a reference
        Reference reference = new Reference("3 John",1, 3, 6);

        // Create a scripture
        Scripture scripture = new Scripture(reference, 
            "For I rejoiced greatly, when the brethren came and testified of the truth that is in thee, even as thou walkest in the truth. I have no greater joy than to hear that my children walk in trut. Beloved, thou doest faithfully whatsoever thou doest to the brethren, and to strangers; Which have borne witness of thy charity before the church: whom if thou bring forward on their journey after a godly sort, thou shalt do well:");

        // Main loop
        while (true)
        {
            TryClearConsole(); // Clear or simulate clearing the console
            Console.WriteLine(scripture.GetScriptureText()); // Display scripture

            if (scripture.AllWordsHidden())
            {
                Console.Write("\nYou have successfully memorized the scripture!");
                break; // Exit the program
            }
            {
                Console.WriteLine();
            }

            Console.Write("\nPress enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break; // Exit the program
            }

            scripture.HideRandomWords(3); // Hide 3 random words
        }
    }

    // Method to attempt clearing the console
    static void TryClearConsole()
    {
        try
        {
            Console.Clear(); // Try clearing the console
        }
        catch
        {
            // If clearing fails, simulate by printing blank lines
            for (int i = 0; i < 50; i++) Console.WriteLine();
        }
    }
}