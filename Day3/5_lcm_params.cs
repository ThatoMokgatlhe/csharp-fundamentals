using System;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine();
        if (line == null) return;

        var bits = line.Split(' ');
        if (bits.Length < 2) return;

        int a = int.Parse(bits[0]);
        int b = int.Parse(bits[1]);

        Console.WriteLine(Lcm(a, b));
    }

    static int Lcm(int a, int b) => (a == 0 || b == 0) ? 0 : Math.Abs(a * b) / Gcd(a, b);

    static int Gcd(int a, int b)
    {
        while (b != 0)
        {
            var t = b;
            b = a % b;
            a = t;
        }
        return a;
    }
}
