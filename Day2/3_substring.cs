using System;

class Program {
    static void ExtractSubstring() {
        string fullText = Console.ReadLine();
        int startIndex = int.Parse(Console.ReadLine());
        int endIndex = int.Parse(Console.ReadLine());

        string resultSubstring = fullText.Substring(startIndex, endIndex - startIndex);
        Console.WriteLine(resultSubstring);
    }

    static void Main() {
        ExtractSubstring();
    }
}
