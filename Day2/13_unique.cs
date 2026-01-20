using System;
using System.Collections.Generic;

class Program {
    static void PrintUniqueElements() {
        string input = Console.ReadLine();
        HashSet<char> uniqueChars = new HashSet<char>();

        foreach (char c in input) {
            if (uniqueChars.Add(c)) {
                Console.Write(c);
            }
        }
    }

    static void Main() {
        PrintUniqueElements();
    }
}
