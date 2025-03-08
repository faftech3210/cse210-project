using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grad percentage ");
        string valueFromUser = Console.ReadLine();
        int grad = int.Parse(valueFromUser);

        string letter = "";

        if (grad >= 90)
        {
            letter = "A";
        }
        else if (grad >= 80)
        {
            letter = "B";
        }
        else if (grad >= 70)
        {
            letter = "C";
        }
        else if (grad >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grad is {letter}");

        if(grad >= 70)
        {
            Console.WriteLine("You passed");
        }
        else
        {
            Console.WriteLine("You failed! study hard next term");
        }
    }
}