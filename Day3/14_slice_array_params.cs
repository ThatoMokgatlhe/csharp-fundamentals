using System;

class Program
{
    static void Main()
    {
        var aStr = Console.ReadLine();
        var rStr = Console.ReadLine();
        if (aStr == null || rStr == null) return;

        var aBits = aStr.Split(' ');
        var nums = new int[aBits.Length];
        for (int i = 0; i < aBits.Length; i++) nums[i] = int.Parse(aBits[i]);

        var rBits = rStr.Split(' ');
        if (rBits.Length < 2) return;

        var res = Slice(nums, int.Parse(rBits[0]), int.Parse(rBits[1]));
        Console.WriteLine(string.Join(" ", res));
    }

    static int[] Slice(int[] a, int s, int l)
    {
        if (s < 0 || s >= a.Length || l < 0) return new int[0];
        var n = Math.Min(l, a.Length - s);
        var r = new int[n];
        for (int i = 0; i < n; i++) r[i] = a[s + i];
        return r;
    }
}
