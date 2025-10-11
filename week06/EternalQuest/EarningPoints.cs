using System;
using System.Collections.Generic;
using System.IO;

class EarningPoints : GoalTracker
{
    private int _points;
    private int _level;

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
        // Additional logic for starting a new game can be added here
    }

    public void LoadSavedGame()
    {
        Console.WriteLine("Loading saved stats...");
        // Additional logic for loading a saved game can be added here
    }

    public void ViewCurrentScores()
    {
        Console.WriteLine($"Your Current Points Total is - {Points}");
        Console.WriteLine($"Your Current Level is - {Level}");
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