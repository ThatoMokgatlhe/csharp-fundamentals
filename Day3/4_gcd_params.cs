using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        if (input == null) return;

        var parts = input.Split(' ');
        if (parts.Length < 2) return;

        Console.WriteLine(Gcd(int.Parse(parts[0]), int.Parse(parts[1])));
    }

    static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            var temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
