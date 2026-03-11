using System;

class Program
{
    static void Main()
    {
        var line = Console.ReadLine();
        if (string.IsNullOrEmpty(line)) return;

        var bits = line.Split(' ');
        var nums = new int[bits.Length];
        for (int i = 0; i < bits.Length; i++) nums[i] = int.Parse(bits[i]);

        Console.WriteLine("Max: " + Max(nums));
    }

    static int Max(int[] a)
    {
        if (a.Length == 0) return 0;
        var m = a[0];
        foreach (var v in a) if (v > m) m = v;
        return m;
    }
}
