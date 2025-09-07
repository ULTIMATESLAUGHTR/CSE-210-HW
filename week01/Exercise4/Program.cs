using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        NumberListAnalyzer analyzer = new NumberListAnalyzer();
        analyzer.Main();
    }
}

class NumberListAnalyzer
{
    public void Main()
    {
        List<int> numbers = new List<int>();
        string input;
        
        Console.WriteLine("Enter only whole numbers (type 'done' to finish):");
        
        // Gets numbers from the user
        while (true)
        {
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            
            // Check if the user wants to stop
            if (input.ToLower() == "done")
            {
                break;
            }
            
            // Try to parse the input as a number
            if (double.TryParse(input, out double number))
            {
                numbers.Add((int)number);
                Console.WriteLine($"Added {(int)number} to the list.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid whole number or 'done' to finish.");
            }
        }
        
        // Checks if any numbers were entered
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered, or you can't add zero or negative numbers.");
            return;
        }

        // Calculates and displays results
        double sum = numbers.Sum();
        double average = numbers.Average();
        double maximum = numbers.Max();

        Console.WriteLine("\n--- Your Results Are... ---");
        Console.WriteLine($"Numbers entered: {numbers.Count}");
        Console.WriteLine($"Numbers: [{string.Join(", ", numbers)}]");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"Maximum: {maximum}");
        
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}