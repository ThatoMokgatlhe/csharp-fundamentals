using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int sum = 0;
        foreach (char c in input)
        {
            if (c >= '0' && c <= '9')
                sum += c - '0';
        }
        Console.WriteLine(sum);
    }
}
