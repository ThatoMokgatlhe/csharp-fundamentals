using System;

class Program {
    static void ReverseArray() {
        string[] numbers = Console.ReadLine().Split();
        for (int i = numbers.Length - 1; i >= 0; i--) {
            Console.Write(numbers[i] + " ");
        }
    }

    static void Main() {
        ReverseArray();
    }
}
