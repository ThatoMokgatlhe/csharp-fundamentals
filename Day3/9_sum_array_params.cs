using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        if (string.IsNullOrEmpty(input)) return;

        var parts = input.Split(' ');
        var nums = new int[parts.Length];
        for (int i = 0; i < parts.Length; i++) nums[i] = int.Parse(parts[i]);

        Console.WriteLine("Sum: " + Sum(nums));
    }

    static int Sum(int[] vals)
    {
        var s = 0;
        foreach (var v in vals) s += v;
        return s;
    }
}
