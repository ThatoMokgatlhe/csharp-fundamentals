using System;

class Program {
    static void MergeArrays() {
        string firstArray = Console.ReadLine();
        string secondArray = Console.ReadLine();
        string merged = firstArray + secondArray;
        Console.WriteLine(merged);
    }

    static void Main() {
        MergeArrays();
    }
}
