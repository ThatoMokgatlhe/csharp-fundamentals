using System;
using System.Collections.Generic;

class Program {
    static void ArrayDifference() {
        string firstLine = Console.ReadLine();
        string secondLine = Console.ReadLine();

        HashSet<char> secondSet = new HashSet<char>(secondLine);
        foreach (char c in firstLine) {
            if (!secondSet.Contains(c)) {
                Console.Write(c);
            }
        }
    }

    static void
