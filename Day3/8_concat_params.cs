using System;

class Program
{
    static void Main()
    {
        var s = Console.ReadLine();
        var sep = Console.ReadLine();
        if (s != null && sep != null) Console.WriteLine(Join(s.Split(','), sep));
    }

    static string Join(string[] p, string s) => string.Join(s, p);
}
