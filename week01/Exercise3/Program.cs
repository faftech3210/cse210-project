using System;

class Program
{
    static void Main(string[] args)
    {
//*****************************************************************
// Part 1 and 2 (User input of both magicNum and guessNum) PLEASE RUN THE CODE SEPERATELY   
        // Console.WriteLine("what is your magic number? ");
        // string answer = Console.ReadLine();
        // int magicNum = int.Parse(answer);
        // Console.WriteLine("what is your guess number");
        // string userGuess = Console.ReadLine();
        // int guessNum = int.Parse(userGuess);

        // if (guessNum < magicNum)
        // {
        //     Console.WriteLine("guess higher");
        // }
        // else if (guessNum > magicNum)
        // {
        //     Console.WriteLine("guess lower");
        // }
        // else if (guessNum == magicNum)
        // {
        //     Console.WriteLine("You guess it!");
        // } 

//***************************************************************
// part 3 start here (RandomGenerator and whil loop) 
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 150);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }      
    }
}