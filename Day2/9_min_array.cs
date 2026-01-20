using System;

class Program {
    static void FindMinInArray() {
        string[] numbers = Console.ReadLine().Split();
        int minValue = int.Parse(numbers[0]);

        foreach (string num in numbers) {
            int current = int.Parse(num);
            if (current < minValue) minValue = current;
        }

        Console.WriteLine(minValue);
    }

    static void Main() {
        FindMinInArray();
    }
}
