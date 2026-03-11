using System;

class Program
{
    static void Main()
    {
        var s = Console.ReadLine();
        if (s != null) Console.WriteLine(Fib(int.Parse(s)));
    }

    static int Fib(int n)
    {
        if (n <= 0) return 0;
        if (n == 1) return 1;
        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            var t = a + b;
            a = b;
            b = t;
        }
        return b;
    }
}
