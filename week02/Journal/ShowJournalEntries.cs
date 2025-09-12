using System;
using System.Collections.Generic;
using System.IO;

class ShowJournalEntries
{
    private string _filename;

    public ShowJournalEntries(string fileName = "ShowJournalEntries.txt")
    {
        _filename = fileName;
    }

    public void DisplayEntries(List<JournalEntry> entries)
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries to display.");
            return;
        }
        Console.WriteLine("Here are your saved journal entries:");
        foreach (var entry in entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    //This one is to save the entry to the text file of the same name.
    public void SaveEntry(JournalEntry entry)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(_filename, true))
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
            Console.WriteLine("Journal entry saved.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the journal entry: {ex.Message}");
        }
    }
}
