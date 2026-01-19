using System;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int max = int.Parse(input[0]);
        for (int i = 1; i < input.Length; i++)
        {
            int num = int.Parse(input[i]);
            if (num > max)
                max = num;
        }
        Console.WriteLine("Max: " + max);
    }
}
