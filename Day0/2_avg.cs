using System;

class Program
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double avg = (a + b + c) / 3;
        Console.WriteLine("Average: " + avg.ToString("F2"));
    }
}
