using System;

class Program {
    static void SplitAndPrint() {
        string fruits = Console.ReadLine();
        string[] fruitList = fruits.Split(',');

        foreach (string fruit in fruitList) {
            Console.WriteLine(fruit.Trim());
        }
    }

    static void Main() {
        SplitAndPrint();
    }
}