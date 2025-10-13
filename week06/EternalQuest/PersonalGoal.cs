using System;
using System.Collections.Generic;
using System.IO;

class PersonalGoal : GoalTracker
{
    public void SetGoal()
    {
        Console.WriteLine("Welcome to the Personal Goal Tracker!");
        Console.WriteLine("Write down your personal Goal. If you complete it, you'll earn 10 points!");
        string goal = Console.ReadLine();
    }

    public PersonalGoal(string playerName) : base(playerName)
    {
        Console.WriteLine("Welcome to the Personal Goal Tracker!");
        Console.WriteLine("Write down your personal Goal. If you complete it, you'll earn 10 points!");
        string goal = Console.ReadLine();
        SetPersonalGoal(goal);
        LoadTitles();
        DisplayStatus();
        Console.WriteLine("Did you complete your personal goal? type 'yes' or 'no'");
        string response = Console.ReadLine().ToLower();
        if (response == "yes")
        {
            Console.WriteLine("Congratulations on completing your personal goal! You've earned 10 points.");
            AddPoints(10);
            SaveTitles();
        }
        else
        {
            Console.WriteLine("No worries! Keep going! Once you do, you'll earn those points and feel good too!");
            DisplayStatus();

        }
    }
}