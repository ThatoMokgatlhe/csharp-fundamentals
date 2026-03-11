using System;

class Program
{
    static void Main()
    {
        var s = Console.ReadLine();
        if (s != null) Console.WriteLine(Reverse(s));
    }

    static string Reverse(string s)
    {
        var res = "";
        for (int i = s.Length - 1; i >= 0; i--) res += s[i];
        return res;
    }
}
