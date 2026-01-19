using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        Console.WriteLine(words.Length);
    }
}
