using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        foreach (Goal goal in _goals)
        {
            if (goal.Name == goalName)
            {
                int pointsEarned = goal.RecordEvent();
                _score += pointsEarned;
                Console.WriteLine($"Event recorded for '{goalName}'. You earned {pointsEarned} points!");
                return;
            }
        }
        Console.WriteLine($"No goal found with the name '{goalName}'.");
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_score}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            outputFile.WriteLine($"Score,{_score}");
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);
            _goals.Clear();
            foreach (string line in lines)
            {
                if (line.StartsWith("Score"))
                {
                    _score = int.Parse(line.Split(',')[1]);
                }
                else
                {
                    _goals.Add(Goal.CreateGoal(line));
                }
            }
        }
    }
}
