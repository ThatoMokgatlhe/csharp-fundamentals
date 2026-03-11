using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        if (input == null) return;

        var n = int.Parse(input);
        Console.WriteLine(IsPrime(n) ? "Prime" : "Not prime");
    }

    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2) return true;
        if (n % 2 == 0) return false;

        for (int i = 3; i * i <= n; i += 2)
            if (n % i == 0) return false;

        return true;
    }
}
