using System;

class Program
{
    static void Main()
    {
        var s = Console.ReadLine();
        if (s != null) Console.WriteLine(CountVowels(s));
    }

    static int CountVowels(string s)
    {
        var count = 0;
        var v = "aeiouAEIOU";
        foreach (var c in s) if (v.IndexOf(c) != -1) count++;
        return count;
    }
}
