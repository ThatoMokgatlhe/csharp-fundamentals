using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        int count = 0;
        foreach (char c in input)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                count++;
        }
        Console.WriteLine(count);
    }
}
