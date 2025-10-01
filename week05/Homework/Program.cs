using System;

class Program
{
    static void Main(string[] args)
    {
        Assignments a1 = new Assignments("John Doe", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Jane Smith", "Fractions", "7.3", "1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());


        WritingAssignment a3 = new WritingAssignment("Emily Johnson", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}