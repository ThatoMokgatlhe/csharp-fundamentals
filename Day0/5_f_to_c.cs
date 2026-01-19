using System;

class Program
{
    static void Main()
    {
        double f = double.Parse(Console.ReadLine());
        double c = (f - 32) * 5 / 9;
        Console.WriteLine("Celsius: " + c.ToString("F1"));
    }
}
