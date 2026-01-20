using System;

class Program {
    static void TrimSpaces() {
        string textWithSpaces = Console.ReadLine();
        string trimmedText = textWithSpaces.Trim();
        Console.WriteLine(trimmedText);
    }

    static void Main() {
        TrimSpaces();
    }
}
