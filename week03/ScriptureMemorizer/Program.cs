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
        else
        {

            while (true)
            {
                Console.Clear();
                var hider = new ScriptureHider(randomScripture.Text);
                hider.HideRandomWords(2);
                Console.WriteLine($"{randomScripture.Reference}: {hider.GetHiddenText()}");

                if (hider.GetHiddenText().Contains("_"))
                {
                    Console.WriteLine("\nPress Enter to hide more words or type 'quit' to quit.");
                    if (Console.ReadLine().ToLower() == "quit")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\nAll words are hidden! Press Enter one more time to exit the program and get a new scripture to memorize.");
                    Console.ReadLine();
                    break;
                }
        }
        }
    }
}