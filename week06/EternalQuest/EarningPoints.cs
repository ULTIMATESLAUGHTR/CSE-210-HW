using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;

class EarningPoints : GoalTracker
{
    private int _points;
    private int _level;

    private string _currentTitle;

    private List<string> _titles;
    private const string SaveFilePath = "game_save.txt";
    public EarningPoints(string playerName) : base(playerName)
    {
        _points = 0;
        _level = 1;
        _titles = new List<string>();

    }
    public void StartNewGame()
    {
        Console.WriteLine("Starting fresh... No Stats at the Moment... Let's Change That!");
    
    }

    public void LoadSavedGame()
    {
        Console.WriteLine("Loading saved stats...");
        
    }

    public void ViewCurrentStatus()
    {
        Console.WriteLine($"Your Current Points Total is - {Points}");
        Console.WriteLine($"Your Current Level is - {Level}");
        Console.WriteLine("Your Titles Earned So Far:");
        foreach (var title in Titles)
        {
            Console.WriteLine($" - {title}");
        }
    }

    public void SaveGame()
    {
        Console.WriteLine("Saving your progress...");
        
    }

    public void ExitGame()
    {
        Console.WriteLine("Exiting the Eternal Goal Game. See you next time!");

    }
    





}