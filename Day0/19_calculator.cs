using System;

class Program
{
    static void Main()
    {
        double num1 = double.Parse(Console.ReadLine());
        string op = Console.ReadLine();
        double num2 = double.Parse(Console.ReadLine());
        double result = 0;
        
        if (op == "+")
            result = num1 + num2;
        else if (op == "-")
            result = num1 - num2;
        else if (op == "*")
            result = num1 * num2;
        else if (op == "/")
            result = num1 / num2;
        
        Console.WriteLine(result.ToString("F2"));
    }
}
