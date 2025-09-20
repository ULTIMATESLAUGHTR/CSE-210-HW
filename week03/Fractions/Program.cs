using System;

class Program
{
    static void Main(string[] args)
    {
        HoldFractions f1 = new HoldFractions(0);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        HoldFractions f2 = new HoldFractions(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        HoldFractions f3 = new HoldFractions(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        HoldFractions f4 = new HoldFractions(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        }
    }
