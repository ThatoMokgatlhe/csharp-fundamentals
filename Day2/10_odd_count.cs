using System;

class Program {
    static void CountOddNumbers() {
        string[] numbers = Console.ReadLine().Split();
        int oddCount = 0;

        foreach (string num in numbers) {
            int value = int.Parse(num);
            if (value % 2 != 0) oddCount++;
        }

        Console.WriteLine(oddCount);
    }

    static void Main() {
        CountOddNumbers();
    }
}
