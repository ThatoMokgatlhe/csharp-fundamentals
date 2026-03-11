using System;

class Program
{
    static void Main()
    {
        var s = Console.ReadLine();
        var c = Console.ReadLine();
        if (s != null && !string.IsNullOrEmpty(c))
            Console.WriteLine(Count(s, c[0]));
    }

    static int Count(string s, char c)
    {
        var n = 0;
        foreach (var ch in s) if (ch == c) n++;
        return n;
    }
}
