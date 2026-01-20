using System;

class Program {
    static void PrintStringLength() {
        string userInput = Console.ReadLine();
        int stringLength = userInput.Length;
        Console.WriteLine(stringLength);
    }

    static void Main() {
        PrintStringLength();
    }
}
