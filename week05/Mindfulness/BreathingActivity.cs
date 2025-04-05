using System;

namespace MindfulnessApp
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity() : base( "Welcome to breathing Activity", "This activity will help you relax by guiding your breathing in and out slowly.") { }

        public override void Run()
        {
            DisplayStartingMessage();
            for (int i = 0; i < _duration; i += 5)
            {
                Console.Write("Breathe in...");
                ShowCountDown(5);
                Console.Write("\b \b");
            
                Console.Write("Breathe out...");
                ShowCountDown(5);
                Console.Write("\b \b");
                
            }
            DisplayEndingMessage();
        }
    }
}
