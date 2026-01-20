using System;

class Program {
    static void ConvertToLowercase() {
        string originalText = Console.ReadLine();
        string lowerText = originalText.ToLower();
        Console.WriteLine(lowerText);
    }

    static void Main() {
        ConvertToLowercase();
    }
}
