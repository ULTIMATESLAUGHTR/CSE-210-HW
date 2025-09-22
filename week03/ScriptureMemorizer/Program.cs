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

        // This will hide the scripture for each iteration.

        var hider = new ScriptureHider(randomScripture.Text);

        while (!hider.AllWordsHidden)
        {
            Console.Clear();

            // This hides words on the SAME hider instance
            hider.HideRandomWords(3);
            Console.WriteLine($"{randomScripture.Reference}: {hider.GetHiddenText()}");

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to quit.");
            if (Console.ReadLine().ToLower() == "quit")
            {
                break;
            }
        }

        if (hider.AllWordsHidden)
        {
            Console.Clear();
            Console.WriteLine($"{randomScripture.Reference}: {hider.GetHiddenText()}");
            Console.WriteLine("\nAll the scripture's words are hidden! You've completed the memorization exercise. When you're ready...");
            Console.WriteLine("Press the Enter key to exit, or type again for a new scripture.");
            Console.ReadLine();

            if (Console.ReadLine().ToLower() == "again")
            {
                Main(); // Restarts the process for a new scripture memorization program.
            }
            else if (Console.ReadLine().ToLower() == "quit")
            {
                return;
            }
        }
    }
}