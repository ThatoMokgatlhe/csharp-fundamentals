using System;

class Program {
    static void CheckStringContains() {
        string mainText = Console.ReadLine();
        string searchText = Console.ReadLine();

        if (mainText.Contains(searchText))
            Console.WriteLine("Found");
        else
            Console.WriteLine("Not found");
    }

    static void Main() {
        CheckStringContains();
    }
}
