using System;
using System.Collections.Generic;

class ScriptureActivity : GoalTracker
{
    public ScriptureActivity(string playerName) : base(playerName)
    {
        Console.WriteLine("Welcome to the Reading Scripture Scheduling Activity!");
        Console.WriteLine("How many days a week have you read? Type a number between 1-7. For each day you've read, you will earn 5 points!");
        int daysRead = int.Parse(Console.ReadLine());
        int pointsEarned = daysRead * 5;
        AddPoints(pointsEarned);
        Console.WriteLine($"Great job! You've earned {pointsEarned} points for reading {daysRead} days this week.");
        Console.WriteLine("Keep going! If you haven't read so much this week, make it a goal to read more often, and get more points for doing so!");
        LoadTitles();
        DisplayStatus();
        Console.WriteLine("Remember, reading scripture not only earns you points but also enriches your spirit. Keep it up!");
    }

    public void StartScriptureActivity()
    {
        Console.WriteLine($"{PlayerName}, you have started the Scripture Activity!");

    }
}