using System;

class Program {
    static void SumOddNumbers() {
        string[] numbers = Console.ReadLine().Split();
        int sum = 0;

        foreach (string num in numbers) {
            int value = int.Parse(num);
            if (value % 2 != 0) sum += value;
        }

        Console.WriteLine(sum);
    }

    static void Main() {
        SumOddNumbers();
    }
}
