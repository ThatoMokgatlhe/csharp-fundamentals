using System;

class Program {
    static void PrintFactorialSeries() {
        int limit = int.Parse(Console.ReadLine());
        int factorial = 1;

        for (int i = 1; i <= limit; i++) {
            factorial *= i;
            Console.WriteLine($"{i}! = {factorial}");
        }
    }

    static void Main() {
        PrintFactorialSeries();
    }
}
