using System;
using System.Collections.Generic;
using System.IO;

abstract class GoalTracker
{
    public string PlayerName { get; set; }
    public int Points { get; set; }
    public int Level { get; set; }
    public List<string> Titles { get; set; }
    public List<string> PersonalGoals { get; set; }

    public GoalTracker(string playerName)
    {
        PlayerName = playerName;
        Points = 0;
        Level = 1;
        Titles = new List<string>();
        PersonalGoals = new List<string>();
    }

    public void AddPoints(int points)
    {
        Points += points;
        CheckLevelUp();
    }

    private void CheckLevelUp()
    {
        int requiredPointsForNextLevel = Level * 100; // Example leveling system
        if (Points >= requiredPointsForNextLevel)
        {
            Level++;
            Titles.Add($"Level {Level} Achiever");
            Console.WriteLine($"Congratulations {PlayerName}, you've leveled up to Level {Level}!");
            SaveTitles();
        }
    }

    public void SetPersonalGoal(string goal)
    {
        PersonalGoals.Add(goal);
        AddPoints(10); // Reward for setting a personal goal
        Console.WriteLine($"Personal goal '{goal}' added! You've earned 10 points.");
        SaveTitles();
    }
    private string TitlesFilePath => $"{PlayerName}_titles.txt";
    private void SaveTitles()
    {
        try
        {
            File.WriteAllLines(TitlesFilePath, Titles);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving titles: {ex.Message}");
        }
    }
    public void LoadTitles()
    {
        string path = GetTitlesFilePath(), Titles);
        if (File.Exists(path))
        {
            try
            {
                Titles = new List<string>(File.ReadAllLines(path));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading titles: {ex.Message}");
            }
        }
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Player: {PlayerName}");
        Console.WriteLine($"Level: {Level}");
        Console.WriteLine($"Points: {Points}");
        Console.WriteLine("Titles: " + (Titles.Count > 0 ? string.Join(", ", Titles) : "None"));
        Console.WriteLine("Personal Goals: " + (PersonalGoals.Count > 0 ? string.Join(", ", PersonalGoals) : "None"));
    }
}