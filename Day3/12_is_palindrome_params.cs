using System;

class Program
{
    static void Main()
    {
        var s = Console.ReadLine();
        if (s != null) Console.WriteLine(IsPal(s) ? "Palindrome" : "Not a palindrome");
    }

    static bool IsPal(string s)
    {
        var c = "";
        foreach (var ch in s)
            if (char.IsLetterOrDigit(ch)) c += char.ToLower(ch);

        for (int i = 0; i < c.Length / 2; i++)
            if (c[i] != c[c.Length - 1 - i]) return false;
        return true;
    }
}
