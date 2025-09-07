using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        ClassicProgram program = new ClassicProgram();
        program.MainProgram();
    }
}

class ClassicProgram
{
    public void MainProgram()
    {
        FunctionsList functions = new FunctionsList();
        functions.DisplayWelcome();
        string name = functions.DisplayName();
        Console.WriteLine($"Hello, {name}!");

        bool continueLoop = true;
        while (continueLoop)
        {
            try
            {
                int userNumber = functions.GetUserInput();
                int squaredNumber = functions.SquareNumber(userNumber);
                functions.DisplayResult(squaredNumber);
                continueLoop = false; // Exits the loop after successful input and processing
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, please enter a valid integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Sorry, the number entered is too large or too small. Please try again.");
            }
        }
    }
}

class FunctionsList
{
    public void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Input Program!");
    }

    public string DisplayName()
    {
        Console.WriteLine("Please enter your first and last name: ");
        string name = Console.ReadLine();
        return CapitalizeName(name);
    }

    public int GetUserInput()
    {
        Console.Write("Please enter a number: ");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    public int SquareNumber(int number)
    {
        return number * number;
    }

    public void DisplayResult(int squaredNumber)
    {
        Console.WriteLine($"The square of your number is: {squaredNumber}");
    }

    // Capitalizes the first letter of each word in the name
    private string CapitalizeName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return name;

        var words = name.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
        }
        return string.Join(" ", words);
    }
}