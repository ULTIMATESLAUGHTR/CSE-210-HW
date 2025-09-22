using System;

class Program
{
    public static void Main()
    {
        var collection = new ScriptureCollection();

        Console.WriteLine("Here's a random Scripture to memorize:");
        var randomScripture = collection.GetRandomScripture();
        Console.WriteLine(randomScripture);

        Console.WriteLine("\nPress Enter to hide random words until the entire scripture is hidden, or type 'quit' to quit.");

        if (Console.ReadLine().ToLower() == "quit")
        {
            return;
        }
    }
}