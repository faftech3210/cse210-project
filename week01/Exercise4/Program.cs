using System;

class Program
{
    static void Main(string[] args)
    
    {
        List<int> numbers  = new List<int>();
        int userNum = -1;
        while (userNum != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 to quit");
            string userInput = Console.ReadLine();
            userNum = int.Parse(userInput);

            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }
// Part 1: Compute the sum ********************************************** 
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


// Part 2: to get the average number in list***************************** 
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

// Part 3: Find the max**************************************************
        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}