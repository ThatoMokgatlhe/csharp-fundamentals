using System;

class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        if (input == null) return;
        
        var parts = input.Split(' ');
        if (parts.Length < 2) return;

        int a = int.Parse(parts[0]);
        int b = int.Parse(parts[1]);

        Console.WriteLine("Sum: " + Add(a, b));
    }

    static int Add(int a, int b) => a + b;
}
