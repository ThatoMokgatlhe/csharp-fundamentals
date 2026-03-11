using System;

class Program
{
    static void Main()
    {
        var bStr = Console.ReadLine();
        var eStr = Console.ReadLine();
        
        if (bStr == null || eStr == null) return;

        Console.WriteLine(Power(double.Parse(bStr), int.Parse(eStr)));
    }

    static double Power(double b, int e) => Math.Pow(b, e);
}
