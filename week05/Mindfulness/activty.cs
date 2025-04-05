using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class Activity
    {
        protected string _name;
        protected string _description;
        protected int _duration;

        protected Activity(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public void DisplayStartingMessage()
        {
            Console.WriteLine($"\n--- {_name} ---");
            Console.WriteLine();
            Console.WriteLine($"{_description}");
            Console.Write("Enter the duration of the activity in seconds: ");
            _duration = int.Parse(Console.ReadLine() ?? "30");
            Console.Write("Prepare to begin...");
            ShowSpinner(5);
        }

        public void DisplayEndingMessage()
        {
            Console.WriteLine("\nGreat job! You've completed the activity.");
            Console.WriteLine($"Activity: {_name}, Duration: {_duration} seconds");
            ShowSpinner(5);
        }

        protected void ShowSpinner(int seconds)
        {
            List<string> animationStrings = new List<string> { ".",".",".","." };

            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            int i = 0;

            while (DateTime.Now < endTime)
            {
                Console.Write(animationStrings[i]);
                Thread.Sleep(500); 
                Console.Write("\b");
                i = (i + 1) % animationStrings.Count;
            }
        }

        protected void ShowCountDown(int seconds)
        {
            while (seconds > 0)
            {
                Console.Write($"{seconds} ");
                Thread.Sleep(1000);
                seconds--;
            }
            Console.WriteLine();
        }

        public abstract void Run();
    }
}
