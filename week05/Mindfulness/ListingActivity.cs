using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ListingActivity : Activity
    {
        private static readonly List<string> Prompts = new()
        {
            "Who are people that you appreciate?",
            "What is your personal strenght?",
            "Who are people that you have helped this week?",
            "What are some of your personal heroes?"
        };

        public ListingActivity() : base("Welcomemes to Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can.") { }

        public override void Run()
        {
            DisplayStartingMessage();
            Random random = new();
            Console.WriteLine(Prompts[random.Next(Prompts.Count)]);
            Console.Write("Start listing items (type each item and press Enter):");

            ShowCountDown(5);

        

            var itemCount = 0;
            var endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.ReadLine();
                itemCount++;
            }

            Console.WriteLine($"You listed {itemCount} items!");
            DisplayEndingMessage();
        }
    }
}
