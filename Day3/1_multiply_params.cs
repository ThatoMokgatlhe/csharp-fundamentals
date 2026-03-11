using System;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine();
        if (line == null) return;

        var bits = line.Split(' ');
        if (bits.Length < 2) return;

        PrintProduct(int.Parse(bits[0]), int.Parse(bits[1]));
    }

    static void PrintProduct(int x, int y)
    {
        Console.WriteLine("Product: " + (x * y));
    }
}
