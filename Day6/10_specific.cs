using System;

public class Calculator {
    public int Divide(int a, int b) => a / b;
}

class Program {
    static void Main() {
        try {
            int a = int.Parse("10");
            int b = int.Parse("0");
            new Calculator().Divide(a, b);
        } catch (DivideByZeroException) {
            Console.WriteLine("Cannot divide by zero");
        } catch (FormatException) {
            Console.WriteLine("Invalid format");
        }
    }
}
