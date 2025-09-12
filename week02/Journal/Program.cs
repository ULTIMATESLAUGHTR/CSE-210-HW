using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    private static List<JournalEntry> _entries = new List<JournalEntry>();
    private const string _filename = "ShowJournalEntries.txt";

    private static void LoadEntriesFromFile()
    {
        _entries.Clear(); // Clear existing entries before loading
        if (File.Exists(_filename))
        {
            try
            {
                string[] lines = File.ReadAllLines(_filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        var entry = new JournalEntry(false)
                        {
                            Date = parts[0].Trim(),
                            Prompt = parts[1].Trim(),
                            Response = parts[2].Trim()
                        };
                        _entries.Add(entry);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }

    private static void SaveEntriesToFile()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(_filename))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
            Console.WriteLine("Entries saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving to file: {ex.Message}");
        }
    }

    static void Main(string[] args)
    {
        LoadEntriesFromFile();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nWelcome to the Journal Project Assignment!");
            Console.WriteLine("Please select an option from the menu...");
            Console.WriteLine("1. Write a Journal Entry");
            Console.WriteLine("2. View saved Journal Entries");
            Console.WriteLine("3. Save and Exit");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("You chose to write a journal entry.");
                    Console.WriteLine("Would you like to get a writing prompt? (yes/no)");
                    string promptAnswer = Console.ReadLine().ToLower();
                    bool usePrompt = promptAnswer == "yes";
                    JournalEntry entry = new JournalEntry(usePrompt);
                    _entries.Add(entry);

                    if (usePrompt)
                    {
                        PromptGenerator promptGen = new PromptGenerator();
                        string prompt = promptGen.GetRandomPrompt();
                        Console.WriteLine($"Here is your prompt: {prompt}");
                    }
                    else if (promptAnswer == "no")
                    {
                        Console.WriteLine("No prompt will be provided. You can write freely.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 'yes' or 'no' only.");
                    }
                    
                    Console.WriteLine("Would you like to write another entry? (yes/no)");
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        JournalEntry secondEntry = new JournalEntry(usePrompt);
                        _entries.Add(secondEntry);
                        Console.WriteLine("another journal entry has been created.");
                    }
                    SaveEntriesToFile(); // Save after adding entries
                    break;

                case "2":
                    if (_entries.Count == 0)
                    {
                        Console.WriteLine("No entries found.");
                    }
                    else
                    {
                        Console.WriteLine("\nYour journal entries:");
                        foreach (var journalEntry in _entries)
                        {
                            journalEntry.Display();
                        }
                    }
                    break;

                case "3":
                    SaveEntriesToFile();
                    Console.WriteLine("Thank you for using the Journal Program!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Sorry please enter a number between 1-3.");
                    break;
            }
        }
    }
}