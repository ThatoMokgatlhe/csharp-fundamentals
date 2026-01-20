using System;

class Program {
    static void CategorizeAge() {
        int age = int.Parse(Console.ReadLine());
        string category;

        if (age <= 12) category = "Child";
        else if (age <= 19) category = "Teen";
        else if (age <= 59) category = "Adult";
        else category = "Senior";

        Console.WriteLine(category);
    }

    static void Main() {
        CategorizeAge();
    }
}
