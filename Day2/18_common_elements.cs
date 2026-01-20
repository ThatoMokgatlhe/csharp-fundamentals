using System;
using System.Collections.Generic;

class Program {
    static void FindCommonElements() {
        string firstLine = Console.ReadLine();
        string secondLine = Console.ReadLine();

        HashSet<char> firstSet = new HashSet<char>(firstLine);
        foreach (char c in secondLine) {
            if (firstSet.Contains(c)) {
                Console.Write(c);
            }
        }
    }

    static void Main() {
        FindCommonElements();
    }
}
